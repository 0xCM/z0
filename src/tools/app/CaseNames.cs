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

    public readonly struct CaseNames
    {
        public const string CoreClrBuildLog = "CoreCLR_Windows_NT__x64__Debug.log";
    }

    // dumpbin /SYMBOLS /OUT:j:\database\tools\DumpBin\output\CommandLine\CommandLine.disasm.nobytes.asm J:\lang\net\runtime\artifacts\bin\coreclr\Windows_NT.x64.Release\PDB\ildasm.pdb
    //
    // "J:\lang\net\symreader\.dotnet\dotnet.exe" exec --depsfile "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.deps.json" --runtimeconfig "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.runtimeconfig.json"  "J:\cache\nuget\cache\xunit.runner.console/2.4.1/tools/netcoreapp2.0/xunit.console.dll" "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.dll" -noautoreporters -xml "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.xml" -html "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.html"  > "J:\lang\net\symreader\artifacts\log\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.log" 2>&1

    // "J:\lang\net\symreader\.dotnet\dotnet.exe" exec --depsfile "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.deps.json" --runtimeconfig "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.runtimeconfig.json"  "J:\cache\nuget\cache\xunit.runner.console/2.4.1/tools/netcoreapp2.0/xunit.console.dll" "J:\lang\net\symreader\artifacts\bin\Microsoft.DiaSymReader.UnitTests\Debug\netcoreapp3.1\Microsoft.DiaSymReader.UnitTests.dll" -noautoreporters -xml "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.xml" -html "J:\lang\net\symreader\artifacts\TestResults\Debug\Microsoft.DiaSymReader.UnitTests_netcoreapp3.1_x64.html"

    // dumpbin /headers /OUT:j:\database\tools\DumpBin\output\ildasm.symbols.log J:\lang\net\runtime\artifacts\bin\coreclr\Windows_NT.x64.Release\PDB\ildasm.pdb

    // llvm-pdbutil dump --streams J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.streams.log
    // llvm-pdbutil dump --streams --stream-blocks J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.streamblocks.log
    // llvm-pdbutil dump --summary J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.summary.log
    // llvm-pdbutil dump --files J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.files.log
    // llvm-pdbutil dump --modules J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.modules.log
    // llvm-pdbutil dump --symbols J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.symbols.log
    // llvm-pdbutil dump --symbols --sym-data J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.symdata.log
    // llvm-pdbutil dump --section-map J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.map.log
    // llvm-pdbutil dump --string-table J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.stringtable.log
    // llvm-pdbutil dump --all J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.all.log
    // llvm-pdbutil diadump --funcsigs J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64\z0.math.pdb > z0.math.pdb.funcsigs.log
    // llvm-pdbutil dump --all J:\lang\net\runtime\artifacts\bin\coreclr\Windows_NT.x64.Release\PDB\ildasm.pdb > J:\database\tools\llvm-pdbutil\output\ildasm.pdb.log

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