//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Git
{
    using System.IO;

    public static class GitMediaTypes
    {
        public const string PrefetchPackFilesAndIndexesMediaType = "application/x-gvfs-timestamped-packfiles-indexes";

        public const string LooseObjectMediaType = "application/x-git-loose-object";

        public const string CustomLooseObjectsMediaType = "application/x-gvfs-loose-objects";

        public const string PackFileMediaType = "application/x-git-packfile";
    }
}