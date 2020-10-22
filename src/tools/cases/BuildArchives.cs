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