//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static BuildArchiveLabels;

    using AN = BuildArchiveNames;
    using AP = BuildArchivePaths;

    // "J:\lang\net\symreader\.dotnet\dotnet.exe" exec --depsfile "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.deps.json" --runtimeconfig "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.runtimeconfig.json"  "J:\cache\nuget\cache\xunit.runner.console/2.4.1/tools/netcoreapp2.0/xunit.console.dll" "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.dll" -noautoreporters -xml "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.xml" -html "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.html"  > "J:\lang\net\symreader\artifacts\log\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.log" 2>&1

    // "J:\lang\net\symreader\.dotnet\dotnet.exe" exec --depsfile "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.deps.json" --runtimeconfig "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.runtimeconfig.json"  "J:\cache\nuget\cache\xunit.runner.console/2.4.1/tools/netcoreapp2.0/xunit.console.dll" "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.dll" -noautoreporters -xml "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.xml" -html "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.html"
    public readonly struct BuildArchiveLabels
    {
        public const string roslyn = nameof(roslyn);

        public const string runtime = nameof(runtime);
    }

    readonly struct BuildArchiveNames
    {
        const string NetLang = "j:/lang/net";

        const string artifacts = nameof(artifacts);

        const string PS = "/";

        public const string Roslyn = NetLang + PS + roslyn + PS + artifacts;

        public const string Runtime = NetLang + PS + runtime + PS + artifacts;
    }

    readonly struct BuildArchivePaths
    {
        public static FS.FolderPath Roslyn => FS.dir(AN.Roslyn);

        public static FS.FolderPath Runtime => FS.dir(AN.Runtime);
    }

    readonly struct BuildArchives
    {
        public static IBuildArchive create(IWfShell wf, FS.FolderPath src)
            => BuildArchive.create(wf, src);

        public static IBuildArchive Roslyn(IWfShell wf)
            =>  BuildArchive.create(wf, AP.Roslyn);

        public static IBuildArchive Z(IWfShell wf)
            => BuildArchive.create(wf, FS.path(wf.Controller.Component.Location).FolderPath);

        public static IBuildArchive Runtime(IWfShell wf)
            => BuildArchive.create(wf, AP.Runtime);

    }

    readonly struct BuildArchiveSpecs
    {
        public static BuildArchiveSpec Roslyn
            => new BuildArchiveSpec(BuildArchiveLabels.roslyn, BuildArchivePaths.Roslyn);

        public static BuildArchiveSpec Runtime
            => new BuildArchiveSpec(BuildArchiveLabels.runtime, BuildArchivePaths.Runtime);
    }
}