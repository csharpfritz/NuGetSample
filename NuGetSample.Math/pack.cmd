@echo off

if \{%1\}==\{\} goto :help
if not exist .\bin\%1\*.dll goto :missing

:: Clean up the existing nuget working folder
rd /s /q nuget
md nuget\lib\dotnet
md dist

:: Copy the DLL to the correct folder

copy .\bin\%1\NuGetSample.Math.dll .\nuget\lib\dotnet

:: Pack the nupkg
nuget pack NuGetSample.Math.nuspec -BasePath nuget -OutputDirectory dist

goto :end

:missing
echo The configuration "%1" is not available.  Check that the project has been
echo compiled properly first.
goto :end

:help
echo Pass a configuration in: "debug" or "release" to pack that version
echo of the project

:end
