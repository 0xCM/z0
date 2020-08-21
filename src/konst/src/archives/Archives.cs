//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Archives : IArchiveServices
    {
        [MethodImpl(Inline)]
        public static IPartCaptureArchive capture(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchives(root ?? EnvVars.Common.LogRoot, area ?? FolderName.Empty, subject ?? FolderName.Empty);

        public static IArchiveServices Services => default(Archives);
    }
}