echo off
ptch Assembly-CSharpPATCHED.il importsnew importsorg Assembly-CSharpPATCHED2.il
echo ________________________________________________
echo Recompiling...
echo ________________________________________________
echo.
ilasm Assembly-CSharpPATCHED2.il /dll /output=Assembly-CSharpPATCHED.dll
pause
cls
echo Done!
pause