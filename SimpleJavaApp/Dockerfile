# Contains the instructions for the Docker Environment to load the required dependencies like JDK, Frameworks and other dependencies required for UR Code to execute. Exception of OS, U must provide all the required dependencies that has to be loaded before UR Application starts. UR Container should contain all the required utilities for UR code to execute in a smooth manner. 

FROM openjdk:11
WORKDIR /var/www/java
COPY . /var/www/java/
RUN javac SimpleFile.java
CMD exec java SimpleFile 