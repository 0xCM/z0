//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct McLogFileType : IFileType<McLogFileType>
    {
        public FS.FileExt DefaultExt => FS.ext("mc.log");
    }

    public readonly struct McLogFile : ITypedFile<McLogFileType>
    {
        public FS.FilePath Path {get;}

        public McLogFileType FileType
            => default;

        [MethodImpl(Inline)]
        public McLogFile(FS.FilePath path)
        {
            Path = path;
        }

        [MethodImpl(Inline)]
        public static implicit operator McLogFile(FS.FilePath src)
            => new McLogFile(src);
    }
}