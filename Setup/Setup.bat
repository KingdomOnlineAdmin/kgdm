echo off
echo Starting Visual Studio Command Prompt
call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\vcvarsall.bat" x86_amd64
echo Generating ILCode
ildasm /out="Assembly-CSharp.il" Assembly-CSharp.dll
echo Patching
ptch Assembly-CSharp.il updatenew updateorg Assembly-CSharpPATCHED.il
pause
Setup2
