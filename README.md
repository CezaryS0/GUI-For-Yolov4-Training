# GUI-For-Yolov4-Training
Windows Forms APP which can generate .CFG files for your yolov4 model, but also train it, hovewer that requires giving it a path to darknet.exe. <br>
The arguments to .exe file will be handled for you, as long as you select correct paths in ConfigurePaths Window and put in appropriate config values batch, subdivisions and Network Size in a Config Window.<br><br>

All required files and Environment are described at github page: https://github.com/AlexeyAB/darknet <br>
The CFG file creation is based on "how to train" tutorial written on the github page above.<br><br>

You must of course compile the darknet file yourself, and select a path to it, in a ConfigWindow <br>

The GUI looks like this:

![Animation](https://user-images.githubusercontent.com/56163226/130072119-ad89672a-bef3-4b4b-8971-e6efbd5fd976.gif)

The black screen void next to buttons is output from the darknet.exe file:

