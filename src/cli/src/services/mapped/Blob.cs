//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;

    partial class CliMemoryMap
    {
        [MethodImpl(Inline), Op]
        public BinaryCode Read(BlobHandle src)
            => CliReader.GetBlobBytes(src);

        [MethodImpl(Inline), Op]
        public ref BinaryCode Read(BlobHandle src, ref BinaryCode dst)
        {
            dst = Read(src);
            return ref dst;
        }
    }
}