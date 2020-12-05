//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Git
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    [ApiHost]
    public static class DotGit
    {
        [MethodImpl(Inline), Op]
        public static string shallow() => Shallow;

        public const string Root = ".git";

        public const string HeadName = "HEAD";

        public const string IndexName = "index";

        public const string PackedRefsName = "packed-refs";

        public const string LockExtension = ".lock";

        public static readonly string Config = Path.Combine(DotGit.Root, "config");

        public static readonly string Head = Path.Combine(DotGit.Root, HeadName);

        public static readonly string BisectStart = Path.Combine(DotGit.Root, "BISECT_START");

        public static readonly string CherryPickHead = Path.Combine(DotGit.Root, "CHERRY_PICK_HEAD");

        public static readonly string MergeHead = Path.Combine(DotGit.Root, "MERGE_HEAD");

        public static readonly string RevertHead = Path.Combine(DotGit.Root, "REVERT_HEAD");

        public static readonly string RebaseApply = Path.Combine(DotGit.Root, "rebase_apply");

        public static readonly string Index = Path.Combine(DotGit.Root, IndexName);

        public static readonly string IndexLock = Path.Combine(DotGit.Root, IndexName + LockExtension);

        public static readonly string PackedRefs = Path.Combine(DotGit.Root, PackedRefsName);

        public static readonly string Shallow = Path.Combine(DotGit.Root, "shallow");


        public static class Logs
        {
            public static readonly string HeadName = "HEAD";

            public static readonly string Name = "logs";

            public static readonly string Root = Path.Combine(DotGit.Root, Logs.Name);

            public static readonly string Head = Path.Combine(Logs.Root, Logs.HeadName);
        }

        public static class Hooks
        {
            public const string QueryWatchmanName = "query-watchman";

            public const string FsMonitorWatchmanSampleName = "fsmonitor-watchman.sample";

            public static readonly string Root = Path.Combine(DotGit.Root, "hooks");

            public static readonly string QueryWatchmanPath = Path.Combine(Hooks.Root, QueryWatchmanName);

            public static readonly string FsMonitorWatchmanSamplePath = Path.Combine(Hooks.Root, FsMonitorWatchmanSampleName);
        }

        public static class Info
        {
            public const string Name = "info";
            public const string SparseCheckoutName = "sparse-checkout";

            public static readonly string Root = Path.Combine(DotGit.Root, Info.Name);
            public static readonly string SparseCheckoutPath = Path.Combine(Info.Root, Info.SparseCheckoutName);
        }

        public static class Objects
        {
            public static readonly string Root = Path.Combine(DotGit.Root, "objects");

            public static class Info
            {
                public static readonly string Root = Path.Combine(Objects.Root, "info");

                public static readonly string Alternates = Path.Combine(Info.Root, "alternates");
            }

            public static class Pack
            {
                public static readonly string Name = "pack";

                public static readonly string Root = Path.Combine(Objects.Root, Name);
            }
        }

        public static class Refs
        {
            public static readonly string RefName = "refs";

            public static string Root => Path.Combine(DotGit.Root, RefName);

            public static class Heads
            {
                public static readonly string Name = "heads";

                public static string Root => Path.Combine(Refs.Root, Name);

                public static string RefName => $"{Refs.RefName}/{Name}";
            }

            public static class Scalar
            {
                public static readonly string Name = "scalar";

                public static string Root => Path.Combine(Refs.Root, Name);

                public static string RefName => $"{Refs.RefName}/{Name}";

                public static class Hidden
                {
                    public static readonly string Name = "hidden";

                    public static string Root => Path.Combine(Scalar.Root, Name);

                    public static string RefName => $"{Scalar.RefName}/{Name}";
                }
            }
        }
    }
}