
# Use a Java base image. You can choose an appropriate tag for your Java version.
FROM openjdk:11-jre

# Set the working directory inside the Docker image
WORKDIR /app

# Copy the JAR file into the image. Assuming your JAR file is named "your-java-server.jar".
COPY iec61850bean-master-1.9.1-SNAPSHOT.jar /app/iec61850bean-master-1.9.1-SNAPSHOT.jar

# Expose the port that your Java server will be listening on.
EXPOSE 8080

# Define the command to start your Java server. Adjust the command as needed for your application.
CMD ["java", "-jar", "iec61850bean-master-1.9.1-SNAPSHOT.jar"]