# GUI-For-Yolov4-Training
Windows Forms APP which can generate .CFG files for your yolov4 model, but also train it, however that requires giving it a path to darknet.exe. <br>
The arguments to .exe file will be handled for you, as long as you select correct paths in ConfigurePaths Window and put in appropriate config values batch, subdivisions and Network Size in a Config Window.<br><br>

<h1>Requirements</h1>

<h2>1. Yolov4 CFG file</h2> 

You must pick and select your yolov4-custom.cfg.

<h2>2. Training data</h2>

Program need to have .names text file with names of objects (each name must be in a separate line)

And the "photos path", which basically is a directory with .jpgs on which you want to train your model and that directory must have TXT files that contain information about objects found in picture.<br>

<h3>Important!</h3>

Every .jpg file must have their .txt file with the same name for instance:

```
img.jpg
img.txt
```
Example of txt file:

```
23 0.770336 0.489695 0.335891 0.697559
23 0.185977 0.901608 0.206297 0.129554
```
Every line must be formatted like this:

```
<object-class> <x_center> <y_center> <width> <height>
```
  
Where first number in line is a class id which is index of name it should be classified with.<br>
Next two floating point numbers are x and y of rectangle with contains object in picture.<br>
Finally third and fourth numbers are width and height of such rectangle.<br><br>

<h2>3. Yolo weights file</h2>

You must select a weights file that looks like this: ```yolov4.conv.137```

<h2>Tutorial</h2>

All required files and Environment are described and can be downloaded at github page: https://github.com/AlexeyAB/darknet <br>
The CFG file creation is based on "how to train" tutorial written on the github page above.<br><br>

You must of course compile the darknet file yourself, and select a path to it, in a ConfigWindow <br>


<h2>GUI</h2>

The GUI looks like this:<br>

![StartScreen](https://user-images.githubusercontent.com/56163226/130598384-e867290f-accb-43a9-af27-0a79d7ae3ec6.gif)

The black screen void next to buttons is output from the darknet.exe file:<br>

![Preview](https://user-images.githubusercontent.com/56163226/130598416-db65613f-ef79-405b-b67f-34faa6387a5f.gif)
