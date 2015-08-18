%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\FullContactDotNet.sln /t:Clean,Rebuild /p:Configuration=Release /fileLogger

rd /s /q packages

mkdir packages\lib\net40\

copy ..\FullContactDotNet\bin\Release\FullContactDotNet.dll packages\lib\net40
copy ..\FullContactDotNet\bin\Release\FullContactDotNet.pdb packages\lib\net40

nuget.exe update -self
nuget.exe pack FullContactDotNet.nuspec -Symbols -BasePath packages