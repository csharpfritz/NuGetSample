@echo off

if \{%1\}==\{\} goto :help
if not exist .\NuGetSample.Math.Managed\bin\%1\*.dll goto :missing

:: Clean up the existing nuget working folder
rd /s /q nuget
md nuget\lib\net40
md dist

:: Copy the DLLs to the correct folder

copy .\NuGetSample.Math.Managed\bin\%1\NuGetSample.Math.Managed.dll .\nuget\lib\net40

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

pause