//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    public static class bitspan
    {                

        public static byte scalar_8(BitSpan src)
            => BitSpan.scalar<byte>(src);

        public static ushort scalar_16(BitSpan src)
            => BitSpan.scalar<ushort>(src);

        public static uint scalar_32(BitSpan src)
            => BitSpan.scalar<uint>(src);

        public static ulong scalar_64(BitSpan src)
            => BitSpan.scalar<ulong>(src);

        public static ushort slice_16(BitSpan src, int offset, int count)
        {
            Span<bit> buffer = stackalloc bit[bitsize<ushort>()];         
            return BitSpan.slice<ushort>(src,offset,count,buffer);
        }

        public static ushort slice_16(BitSpan src, int offset, int count, Span<bit> buffer)
            => BitSpan.slice<ushort>(src,offset,count, buffer);




    }

}