//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;

    using AN = BuildArchiveNames;
    using AP = BuildArchivePaths;

    public readonly struct BuildArchiveNames
    {
        const string NetLang = "j:/lang/net";

        const string roslyn = nameof(roslyn);

        const string artifacts = nameof(artifacts);

        const string PS = "/";

        public const string Roslyn = NetLang + PS + roslyn + PS + artifacts;
    }

    public readonly struct BuildArchivePaths
    {
        public static FS.FolderPath Roslyn => FS.dir(AN.Roslyn);
    }


    public readonly struct BuildArchives
    {
        public static IBuildArchive Roslyn(IWfShell wf)
            =>  BuildArchive.create(wf, AP.Roslyn);
    }
}


// J:\lang\net\roslyn\artifacts