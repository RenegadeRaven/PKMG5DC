:menu
@echo off
cls
echo Pokemon Duodecuple Distribution v1.4.1 "Skinless"
echo -------------------------------------------------
echo 1. Create a 12-distro ROM
echo 2. Extract Wonder Cards from a ROM
echo 3. Compile Wonder Cards into a ROM
echo 4. Exit
echo -------------------------------------------------
set choice=
set /p choice=?
if "%choice%"=="1" goto patch
if "%choice%"=="2" goto extract
if "%choice%"=="3" goto compile
if "%choice%"=="4" exit
goto menu

:patch
@echo off
if not exist tools\ndstool.exe goto ndstoolmissing
if not exist tools\armips.exe goto armipsmissing
if not exist tools\ticket.nds goto ticketmissing
cls
cd tools
@echo on
ndstool.exe -x ticket.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin
@echo off
copy data\data.bin data\01.bin
copy data\data.bin data\02.bin
copy data\data.bin data\03.bin
copy data\data.bin data\04.bin
copy data\data.bin data\05.bin
copy data\data.bin data\06.bin
copy data\data.bin data\07.bin
copy data\data.bin data\08.bin
copy data\data.bin data\09.bin
copy data\data.bin data\10.bin
copy data\data.bin data\11.bin
copy data\data.bin data\12.bin
if not exist ..\cards\01.bin copy data\data.bin ..\cards\01.bin
if not exist ..\cards\02.bin copy data\data.bin ..\cards\02.bin
if not exist ..\cards\03.bin copy data\data.bin ..\cards\03.bin
if not exist ..\cards\04.bin copy data\data.bin ..\cards\04.bin
if not exist ..\cards\05.bin copy data\data.bin ..\cards\05.bin
if not exist ..\cards\06.bin copy data\data.bin ..\cards\06.bin
if not exist ..\cards\07.bin copy data\data.bin ..\cards\07.bin
if not exist ..\cards\08.bin copy data\data.bin ..\cards\08.bin
if not exist ..\cards\09.bin copy data\data.bin ..\cards\09.bin
if not exist ..\cards\10.bin copy data\data.bin ..\cards\10.bin
if not exist ..\cards\11.bin copy data\data.bin ..\cards\11.bin
if not exist ..\cards\12.bin copy data\data.bin ..\cards\12.bin
del data\data.bin
@echo on
armips.exe 12distro.asm -erroronwarning
if errorlevel 1 goto armipserror
ndstool.exe -c 12distro.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin
@echo off
copy 12distro.nds ..\12distro.nds
rd /S/Q data
del arm9.bin arm7.bin banner.bin header.bin
cd ..
goto menu

:extract
@echo off
if not exist tools\ndstool.exe goto ndstoolmissing
if not exist extract.nds goto extractmissing
cls
cd tools
@echo on
ndstool.exe -x ..\extract.nds -d data
@echo off
copy data\??.bin ..\??.bin
copy data\data.bin ..\data.bin
rd /S/Q data
cd ..
goto menu

:compile
@echo off
if not exist tools\ndstool.exe goto ndstoolmissing
if not exist tools\12distro.nds goto 12distromissing
cls
cd tools
@echo on
ndstool.exe -x 12distro.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin
@echo off
copy ..\cards\??.bin data\??.bin
@echo on
ndstool.exe -c ..\compiled.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin
@echo off
rd /S/Q data
del arm9.bin arm7.bin banner.bin header.bin
cd ..
goto menu

:ndstoolmissing
@echo off
cls
echo Error:
echo   Could not find tools\ndstool.exe.
echo.
echo Press key to continue...
pause >nul
goto menu

:armipsmissing
@echo off
cls
echo Error:
echo   Could not find tools\armips.exe.
echo.
echo Press key to continue...
pause >nul
goto menu

:ticketmissing
@echo off
cls
echo Error:
echo   Could not find tools\ticket.nds.
echo   Put a clean Liberty Ticket distro ROM in the tools folder.
echo.
echo Press key to continue...
pause >nul
goto menu

:extractmissing
@echo off
cls
echo Error:
echo   Could not find extract.nds.
echo   Name the ROM you want to extract from extract.nds.
echo.
echo Press key to continue...
pause >nul
goto menu

:12distromissing
@echo off
cls
echo Error:
echo   Could not find tools\12distro.nds.
echo   Use option 1 to create a 12-distro ROM.
echo.
echo Press key to continue...
pause >nul
goto menu

:armipserror
@echo off
echo Error:
echo   Could not patch the ROM.
echo   This could be caused by erroneous settings in options.asm.
echo.
echo Press key to continue...
pause >nul
goto menu