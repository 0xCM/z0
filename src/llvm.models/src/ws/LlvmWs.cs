//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static LlvmAtoms;

    public readonly struct LlvmAtoms
    {
        public const string build = nameof(build);

        public const string bin = nameof(bin);

        public const string include = nameof(include);

        public const string lib = nameof(lib);
    }

    public interface ILlvmWorkspace : IWorkspace
    {
        FS.FolderPath BuildRoot {get;}

        FS.FolderPath LibDir()
            => BuildRoot + FS.folder(lib);

        FS.FolderPath IWorkspace.Bin()
            => BuildRoot + FS.folder(bin);

        FS.Files ExeBuilds()
            => Bin().Files(FS.Exe);

        FS.Files LibBuilds()
            => LibDir().Files(FS.Lib);
    }

    public sealed class LlvmWs : Workspace<LlvmWs>, ILlvmWorkspace
    {
        [MethodImpl(Inline)]
        public static ILlvmWorkspace create(FS.FolderPath root)
            => new LlvmWs(root);

        [MethodImpl(Inline)]
        LlvmWs(FS.FolderPath root)
            : base(root)
        {
            BuildRoot = root + FS.folder(LlvmAtoms.build);
        }

        public FS.FolderPath BuildRoot {get;}
    }
}