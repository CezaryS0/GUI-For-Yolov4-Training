# GUI-For-Yolov4-Training
Windows Forms APP which can generate .CFG files for your yolov4 model, but also train it, hovewer that requires giving it a path to darknet.exe. <br>
The arguments to .exe file will be handled for you, as long as you select correct paths in ConfigurePaths Window and put in appropriate config values batch, subdivisions and Network Size in a Config Window.<br><br>

All required files and Environment are described at github page: https://github.com/AlexeyAB/darknet <br>
The CFG file creation is based on "how to train" tutorial written on the github page above.<br><br>

You must of course compile the darknet file yourself, and select a path to it, in a ConfigWindow <br>

The GUI looks like this:<br>

![Animation](https://user-images.githubusercontent.com/56163226/130075110-6718fc61-076b-4408-b1a4-5f0c6ad7acc4.gif)


The black screen void next to buttons is output from the darknet.exe file:<br>
![Preview](https://user-images.githubusercontent.com/56163226/130075806-ffa9f468-74ac-4431-83b8-8eaf53f036b8.gif)

