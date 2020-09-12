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
        public static ModuleArchive module(FS.FolderPath root)
            => new ModuleArchive(root);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FolderPath root)
            => new PartCaptureArchive(root ?? EnvVars.Common.LogRoot, FolderName.Empty, FolderName.Empty);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FS.FolderPath root)
            => new PartCaptureArchive(root);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(PartId part)
            => new PartCaptureArchive(EnvVars.Common.LogRoot, FolderName.Define("capture"), FolderName.Define(part.Format()));

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(ArchiveConfig config)
            => capture(FS.dir(config.Root.Name));

        [MethodImpl(Inline), Op]
        public static ISemanticPaths semantic()
            => new SemanticPaths();

        [MethodImpl(Inline)]
        public static IApiHexWriter writer<H>(FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(ApiHexWriter))
                return new ApiHexWriter(dst);
            else
                throw no<H>();
        }

        [MethodImpl(Inline)]
        public static IApiHexReader reader<H>(H rep = default)
            where H : struct, IArchiveReader<H>
        {
            if(typeof(H) == typeof(ApiHexReader))
                return new ApiHexReader();
            else
                throw no<H>();
        }

        [MethodImpl(Inline), Op]
        public static IApiHexArchive x86(FolderPath root)
            => new ApiHexArchive(root);
    }
}