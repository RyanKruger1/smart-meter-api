import requests
import time
import json
import serial
import modbus_tk.defines as cst
from modbus_tk import modbus_rtu

TOKEN_FILE = "token.txt"

def get_token():
    data = {
    "location":"Claremont",
    "name":"Kruger-Residence"
    }
    
    response = requests.post(token_url,json=data)
    if response.status_code == 200:
        print(response)
        return response.json().get('id')
    else:
        print(f"Failed to retrieve token from {url}.")
        return None

def save_token(token):
    with open(TOKEN_FILE, "w") as file:
        file.write(token)

def load_token():
    try:
        with open(TOKEN_FILE, "r") as file:
            return file.read().strip()
    except FileNotFoundError:
        return None

def send_post_request(url, data):
    response = requests.post(url, json=data)
    print(f"POST request sent to {url}. Response: {response.status_code}")

# Set the token endpoint URL
token_url = "http://{{ URL }}/SmartMeter"

# Set the API endpoint URL
api_url = "http://{{ URL }}/Readings/"

# Set the interval between requests in seconds
interval = 60

try:
    # Connect to the slave
    serial_port = serial.Serial(
        port='/dev/ttyUSB0',
        baudrate=9600,
        bytesize=8,
        parity='N',
        stopbits=1,
        xonxoff=0
    )

    master = modbus_rtu.RtuMaster(serial_port)
    master.set_timeout(2.0)
    master.set_verbose(True)
    dict_payload = dict()

    # Retrieve or load the token
    token = load_token()
    if not token:
        token = get_token()
        if token:
            save_token(token)

    if token:
        
        while True:
            data = master.execute(1, cst.READ_INPUT_REGISTERS, 0, 10)
            print(data)
            dict_payload["voltage"] = data[0] / 10.0
            dict_payload["current"] = (data[1] + (data[2] << 16)) / 1000.0  # [A]
            dict_payload["power"] = (data[3] + (data[4] << 16)) / 10.0  # [W]
            dict_payload["powerFactor"] = data[8] / 100.0
        
            str_payload = json.dumps(dict_payload, indent=2)
            print(str_payload)

            send_post_request(api_url+""+token, dict_payload)

            time.sleep(interval)

    else:
        print("Token retrieval failed. Exiting...")

except KeyboardInterrupt:
    print('Exiting script due to keyboard interrupt.')
except Exception as e:
    print(f'An error occurred: {e}')
finally:
    if 'master' in locals():
        master.close()
