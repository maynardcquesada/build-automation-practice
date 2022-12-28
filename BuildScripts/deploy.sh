echo Cleaning Directory
rm -rf "../Leap of Faith/build/"

echo Starting Build Process
'D:\Unity Editors\Unity 2021.3.16f1\Editor\Unity.exe' -quit -bachmode -projectPath "../Leap of Faith/" -executeMethod BuildScript.PerformBuild
echo Ended Build Process