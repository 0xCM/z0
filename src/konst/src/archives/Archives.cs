//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Archives
    {
        [MethodImpl(Inline)]
        static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [MethodImpl(Inline), Op]
        public static FileKinds filekinds(params Assembly[] src)
            => new FileKinds(src.SelectMany(x => x.Types().Tagged<FileKindAttribute>()));

        [MethodImpl(Inline), Op]
        public static ISemanticPaths semantic()
            => new SemanticPaths();

        [MethodImpl(Inline)]
        public static X86UriHexWriter hexwriter<H>(FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(X86UriHexWriter))
                return new X86UriHexWriter(dst);
            else
                throw no<H>();
        }

        [MethodImpl(Inline)]
        public static IX86UriHexReader reader<H>(H rep = default)
            where H : struct, IArchiveReader
        {
            if(typeof(H) == typeof(X86UriHexReader))
                return new X86UriHexReader();
            else
                throw no<H>();
        }

        [MethodImpl(Inline), Op]
        public static X86UriHexArchive x86(FolderPath root)
            => X86UriHexArchive.create(FS.dir(root.Name));
    }
}