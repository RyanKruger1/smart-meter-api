# smart-meter api
Project create as part of the Author's MTECH: Electrical Engineering.

This project showcases the interoperability of IoT and IEC6180. IEC 61850 is an electrical engineering standard that advocates for interoperability in the power grid.

Consists of three parts:
1) Smart-Meter API (.NET, REST)
2) Smart-Meter Residential Client (python, REST)
3) IEC61850 MMS Server and Client (MMS - IEC61850, Java)

The IEC61850 MMS Server and the client were not created by me, It was created by beanIt( https://www.beanit.com/iec-61850/ ),
Their official GitHub page for the iec61850bean project can be found here: https://github.com/beanit/iec61850bean.
I have copied their repo and made changes to their MMS Server to allow communication via API instead of having a static SCL file.

Their license can be found in their repo and in this repo at: _./iec61850bean/iec61850-master/LICENCE.txt_

