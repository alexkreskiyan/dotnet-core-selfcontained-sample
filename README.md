# How to launch and debug
 - run binary:

 ```
 .\bin\Debug\netcoreapp1.0\win10-x64\publish\test.exe
 ```
 - attach in VS Code:
  * `F5` to launch debug task
  * select project by `PID`

# Notes
 - for debugging in VS Code set in __project.json__

```
 "debugType": "portable"
 ```
