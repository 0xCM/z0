//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct McAsmFileType : IFileType<McAsmFileType>
    {
        public FS.FileExt DefaultExt => FS.ext("mc.asm");
    }

    public readonly struct McAsmFile : ITypedFile<McAsmFileType>
    {
        public FS.FilePath Path {get;}

        public McAsmFileType FileType
            => default;

        [MethodImpl(Inline)]
        public McAsmFile(FS.FilePath path)
        {
            Path = path;
        }

        [MethodImpl(Inline)]
        public static implicit operator McAsmFile(FS.FilePath src)
            => new McAsmFile(src);
    }
}