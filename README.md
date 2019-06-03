# WPF NuGet Source Package Bug

This repository is a minimal reproduction for Issue:

- [When including any Page item via NuGet package props/targets files, all included Compile items will lost. · Issue #811 · dotnet/wpf](https://github.com/dotnet/wpf/issues/811)

## How to Reproduce

1. Clone this repository;
1. Compile `Walterlv.DemoPackage` project to generate a NuGet package file `Walterlv.DemoPackage.nupkg`;
1. Run `dotnet restore` for this solution so that this package can be installed into `Walterlv.Bugs.NuGetPackages` project;
1. Compile `Walterlv.Bugs.NuGetPackages` project and you'll get an compiling error.

## Compile

```powershell
PS C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages> msbuild .\Walterlv.Bugs.NuGetPackages\ /t:Rebuild
用于 .NET Framework 的 Microsoft (R) 生成引擎版本 16.1.76+g14b0a930a7
版权所有(C) Microsoft Corporation。保留所有权利。

生成启动时间为 2019/6/3 19:16:02。
项目“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages.csproj”在节点 1 上(Rebuild 个目标)。
_CheckForNETCoreSdkIsPreview:
C:\Program Files\dotnet\sdk\3.0.100-preview5-011568\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.RuntimeIdentifierInference.targets(157,5): message NETSDK1057: 你正在使用 .NET Core 的预览版。请查看 https://aka.ms/dotnet-core-preview [C:\Users\lvyi\D
esktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages.csproj]
CoreClean:
  正在删除文件“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\Walterlv.Bugs.NuGetPackages.csprojAssemblyReference.cache”。
  正在删除文件“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\UniversalWindowStyle.g.cs”。
  正在删除文件“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\GeneratedInternalTypeHelper.g.cs”。
  正在删除文件“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\Walterlv.Bugs.NuGetPackages_MarkupCompile.cache”。
  正在删除文件“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\Walterlv.Bugs.NuGetPackages_MarkupCompile.lref”。
  正在删除文件“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\Walterlv.Bugs.NuGetPackages.exe”。
  正在删除文件“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\Walterlv.Bugs.NuGetPackages.pdb”。
GenerateBindingRedirects:
  ResolveAssemblyReferences 中没有建议的绑定重定向。
项目“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages.csproj”(1)正在节点 1 上生成“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages_
uhnudg3n_wpftmp.csproj”(2) (_CompileTemporaryAssembly 个目标)。
CoreCompile:
  C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn\csc.exe /noconfig /unsafe- /checked- /nowarn:1701,1702,1701,1702 /nostdlib+ /platform:AnyCPU /errorreport:prompt /warn:4 /define:TRACE;DEBUG;N
  ETFRAMEWORK;NET45 /highentropyva+ /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\mscorlib.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v
  4.5\PresentationCore.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\PresentationFramework.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramew
  ork\v4.5\System.Core.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Data.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\S
  ystem.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Drawing.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.IO.Com
  pression.FileSystem.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Numerics.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.
  5\System.Runtime.Serialization.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Windows.Controls.Ribbon.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\F
  ramework\.NETFramework\v4.5\System.Xaml.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Xml.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.N
  ETFramework\v4.5\System.Xml.Linq.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\UIAutomationClient.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.
  NETFramework\v4.5\UIAutomationClientsideProviders.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\UIAutomationProvider.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Mi
  crosoft\Framework\.NETFramework\v4.5\UIAutomationTypes.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\WindowsBase.dll" /debug+ /debug:portable /filealign:512 /optimize- /out:obj\Deb
  ug\net45\Walterlv.Bugs.NuGetPackages.exe /ruleset:"C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Team Tools\Static Analysis Tools\\Rule Sets\MinimumRecommendedRules.ruleset" /subsystemversion:6.00 /target:winexe /wa
  rnaserror- /utf8output /deterministic+ Program.cs C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\obj\Debug\net45\UniversalWindowStyle.g.cs C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.
  NuGetPackages\obj\Debug\net45\GeneratedInternalTypeHelper.g.cs obj\Debug\net45\Walterlv.Bugs.NuGetPackages_uhnudg3n_wpftmp.AssemblyInfo.cs /warnaserror+:NU1605
  对来自后列目录的编译器使用共享编译: C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn
已完成生成项目“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages_uhnudg3n_wpftmp.csproj”(_CompileTemporaryAssembly 个目标)的操作。

C:\Users\lvyi\.nuget\packages\walterlv.demopackage\0.1.0\src\UniversalWindowStyle.xaml(18,17): error MC4005: 无法在类型“Walterlv.Themes.UniversalWindowStyle”上找到 Style Property“TitleBar”。 行 18 位置 17. [C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGet
Packages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages.csproj]
已完成生成项目“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages.csproj”(Rebuild 个目标)的操作 - 失败。


生成失败。

“C:\Users\lvyi\Desktop\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages.csproj”(Rebuild 目标) (1) ->
(MarkupCompilePass2 目标) ->
  C:\Users\lvyi\.nuget\packages\walterlv.demopackage\0.1.0\src\UniversalWindowStyle.xaml(18,17): error MC4005: 无法在类型“Walterlv.Themes.UniversalWindowStyle”上找到 Style Property“TitleBar”。 行 18 位置 17. [C:\Users\lvyi\Desktop\Walterlv.Bugs.NuG
etPackages\Walterlv.Bugs.NuGetPackages\Walterlv.Bugs.NuGetPackages.csproj]

    0 个警告
    1 个错误

已用时间 00:00:01.93
```
