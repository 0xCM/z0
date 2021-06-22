//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    partial class XFs
    {
        public static BinaryReader BinaryReader(this Stream src)
            => new BinaryReader(src);

        public static BinaryReader BinaryReader(this StreamReader src)
            => new BinaryReader(src.BaseStream);

        public static BinaryReader BinaryReader(this StreamReader src, Encoding encoding)
            => new BinaryReader(src.BaseStream, encoding);

        // public static Span<byte> ReadBytes(this FS.FilePath src)
        // {
        //     var size = src.Size;
        //     var buffer = core.alloc<byte>(size);
        //     using var reader = src.Reader();
        //     using var binary = reader.BinaryReader();
        //     binary.Read(buffer);
        //     return buffer;
        // }
    }
}