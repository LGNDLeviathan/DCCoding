# Discovery Centre Software Engineering Technical Exercise

As part of the Discovery Centre, you will be expected to complete a remote pair programming exercise.

In order to take part in this exercise, you will need to get your own PC ready. This will require:
* Installing an IDE of your choice (Visual Studio is recommended but not mandatory).
* Installing this project, ensuring you have a failing test.

You will need to be able to run the SumTests class within your environment which should return a test failure with the `NotImplementedException` exception being thrown.

We recommend using the Visual Studio Community IDE for this project. You are welcome to use a different IDE, but we might not be able to help you with any setup issues.


## Installing Visual Studio

Note that there may be a more recent version of Visual Studio available, for which the instructions may differ.

### C# - Visual Studio Community 2019 - Windows

Download Visual Studio Community from the following link: https://visualstudio.microsoft.com/vs/community/ 

On the website, click Download Visual Studio -> ensure you download the free Community edition. Other editions of the software are not free.

This will download the Visual Studio Installer. Follow the prompts in the installer. When asked to select a Workload, ensure you select `.Net desktop development`. 


### C# - Visual Studio Community 2019 - Mac

Download Visual Studio Community from the following link: https://visualstudio.microsoft.com/vs/mac/ 

On the website, click Download Visual Studio for Mac which will download the Visual Studio Installer. Follow the prompts in the installer. When asked to select a Workload, ensure you select `.Net Core`. 


## Running the solution

You will need to have .Net Core 3.0 SDK or greater installed. You can download .Net Core from here: https://dotnet.microsoft.com/download/visual-studio-sdks

Unzip and import the solution file into visual studio 

Verify you can run the following commands successfully (You should get a failed test with the NotImplementedException thrown)

```bash
dotnet build
dotnet test
```
