# WPF NuGet Source Package Bug

This repository is a minimal reproduction for Issue:

- [When including any Page item via NuGet package props/targets files, all included Compile items will lost. · Issue #811 · dotnet/wpf](https://github.com/dotnet/wpf/issues/811)

## How to Reproduce

1. Clone this repository;
1. Compile `Walterlv.DemoPackage` project to generate a NuGet package file `Walterlv.DemoPackage.nupkg`;
1. Run `dotnet restore` for this solution so that this package can be installed into `Walterlv.Bugs.NuGetPackages` project;
1. Compile `Walterlv.Bugs.NuGetPackages` project and you'll get an compiling error.
