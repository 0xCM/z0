//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static core;

    partial class SRM
    {
        [MethodImpl(Inline), Op]
        public static unsafe MemoryBlock block(byte* pSrc, ByteSize length)
            => new MemoryBlock(pSrc,length);

        [MethodImpl(Inline), Op]
        public static unsafe MemoryBlock block(MemoryBlock src, uint offset, ByteSize length)
        {
            if(available(src, offset, length))
                return new MemoryBlock(src.Pointer + offset, length);
            else
                return MemoryBlock.Empty;
        }
    }
}