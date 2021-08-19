# GUI-For-Yolov4-Training
Windows Forms APP which can generate .CFG files for your yolov4 model, but also train it, hovewer that requires giving it a path to darknet.exe. <br>
The arguments to .exe file will be handled for you, as long as you select correct paths in ConfigurePaths Window and put in appropriate config values batch, subdivisions and Network Size in a Config Window.<br><br>

Training data:

Program need to have .names text file with names of objects (each name must be in a separate line)

And the "photos path" it is a directory with .jpgs on which you want to train your model and with TXT files that contain inforamtion about objects found in picture:

Example of txt file:



All required files and Environment are described at github page: https://github.com/AlexeyAB/darknet <br>
The CFG file creation is based on "how to train" tutorial written on the github page above.<br><br>

You must of course compile the darknet file yourself, and select a path to it, in a ConfigWindow <br>

The GUI looks like this:<br>
```
23 0.770336 0.489695 0.335891 0.697559
23 0.185977 0.901608 0.206297 0.129554
```
![Animation](https://user-images.githubusercontent.com/56163226/130075110-6718fc61-076b-4408-b1a4-5f0c6ad7acc4.gif)


The black screen void next to buttons is output from the darknet.exe file:<br>

![Preview](https://user-images.githubusercontent.com/56163226/130075806-ffa9f468-74ac-4431-83b8-8eaf53f036b8.gif)

