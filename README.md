SR300FaceToMongoDB Version 1.0 Brief Description

What it does: 
Retrieve data from Intel(R) Realsense SR300 and insert the time series body stream data to MongoDB. It support do the raw data record at the same time with inserting to MongoDB.

Data insert to MongoDB includes:
  1. detected face location x,y
  2. landmarks: 78 points on face
  3. pose yaw, pitch, roll of head
  4. expression: mouth, eye, eyebrow
  5. pulse: heart rate

Develop Environment: 
Visual Studio 2013 Ultimate on Win10, 
MongoDB 3.0 on Ubuntu 16.04 LTS

C# MongoDB Driver: 
mongo-C#-Driver-2.3.0 https://mongodb.github.io/mongo-csharp-driver/

Limitations:
Not include the audio data.
A little time delay so the FPS is at around 17 onstead of 30.
