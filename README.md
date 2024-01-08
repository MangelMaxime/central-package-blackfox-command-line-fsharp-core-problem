# Instructions

Running `dotnet build MyProject` reports an error:

```text
/Users/mmangel/Workspaces/temp/central-package-blackfox-command-line-fsharp-core-problem/MyProject/Main.fs(19,13): error FS3349: Feature 'string interpolation' requires the F# library for language version 5.0 or greater. [/Users/mmangel/Workspaces/temp/central-package-blackfox-command-line-fsharp-core-problem/MyProject/tk.EasyBuild.fsproj]
```

If I change `<PackageReference Update="FSharp.Core"/>` to `<PackageReference Include="FSharp.Core">` in `./Directory.Build.props`, the error goes away.

But this is not the recommended way to reference FSharp.Core. [Source](https://github.com/dotnet/fsharp/blob/main/docs/fsharp-core-notes.md#how-to-explicitly-reference-fsharpcore).