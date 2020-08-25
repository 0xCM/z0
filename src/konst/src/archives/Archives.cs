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

    [ApiHost]
    public readonly struct Archives
    {
        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new PartCaptureArchive(root ?? EnvVars.Common.LogRoot, area ?? FolderName.Empty, subject ?? FolderName.Empty);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(PartId part)
            => capture(EnvVars.Common.LogRoot, FolderName.Define("capture"), FolderName.Define(part.Format()));

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(ArchiveConfig config)
            => new PartCaptureArchive(config.Root, FolderName.Empty, FolderName.Empty);

        [MethodImpl(Inline), Op]
        public static ISemanticArchive semantic()
            => new SemanticArchive();

        [MethodImpl(Inline)]
        public static IMemberCodeWriter writer<H>(FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(MemberCodeWriter))
                return new MemberCodeWriter(dst);
            else
                throw no<H>();
        }

        [MethodImpl(Inline)]
        public static IEncodedHexReader reader<H>(H rep = default)
            where H : struct, IArchiveReader<H>
        {
            if(typeof(H) == typeof(EncodedHexReader))
                return new EncodedHexReader();
            else
                throw no<H>();
        }

        [MethodImpl(Inline), Op]
        public static IEncodedHexArchive hex(FolderPath root)
            => new EncodedHexArchive(root);
    }
}