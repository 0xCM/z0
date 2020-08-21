//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IArchiveServices
    {
        IAppPaths AppPathDefault
            => AppPaths.Default;

        FolderPath LogRoot
            => AppPathDefault.LogRoot;

        ISemanticArchive Semantic
            => SemanticArchive.Service;

        IEncodedHexReader EncodedHexReader
            => new EncodedHexReader();

        [MethodImpl(Inline)]
        IEncodedHexArchive EncodedHexArchive(FolderPath root = null)
            => new EncodedHexArchive(root ?? LogRoot);

        [MethodImpl(Inline)]
        MemberCodeWriter MemberCodeWriter(FilePath dst)
            => new MemberCodeWriter(dst);

        [MethodImpl(Inline)]
        IPartCaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => Archives.capture(root ?? LogRoot, area ?? FolderName.Empty, subject ?? FolderName.Empty);

        [MethodImpl(Inline)]
        IPartCaptureArchive CaptureArchive(ArchiveConfig config)
            => Archives.capture(config.Root, FolderName.Empty, FolderName.Empty);
    }
}