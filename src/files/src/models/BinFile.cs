//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    public readonly struct BinFile : IFile
    {
        public BinFile(FS.FilePath src)
        {
            Path = src;
        }

        public FS.FilePath Path {get;}

        public static implicit operator BinFile(FS.FilePath src)
            => new BinFile(src.ChangeExtension(FS.Bin));

        public string Format(PathSeparator sep = PathSeparator.FS, bool quote = false)
            => Path.Format(sep,quote);


        public override string ToString()
            => Format();
    }
}