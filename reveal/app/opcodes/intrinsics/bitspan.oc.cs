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
        public static BitSpan load_scalar_8(byte src)
            => BitSpan.create<byte>(src);

        public static BitSpan load_scalar_8_fill(byte src, in BitSpan dst)
            => BitSpan.fill(src, dst);

        public static BitSpan load_scalar_16(ushort src)
            => BitSpan.create<ushort>(src);

        public static BitSpan load_scalar_16_fill(ushort src, in BitSpan dst)
            => BitSpan.fill(src, dst);

        public static BitSpan load_scalar_32(uint src)
            => BitSpan.create<uint>(src);

        public static BitSpan load_scalar_32_fill(uint src, in BitSpan dst)
            => BitSpan.fill(src, dst);

        public static BitSpan load_scalar_64(ulong src)
            => BitSpan.create<ulong>(src);

        public static BitSpan load_scalar_64_fill(ulong src, in BitSpan dst)
            => BitSpan.fill(src, dst);

        public static byte scalar_8(BitSpan src)
            => BitSpan.extract<byte>(src);

        public static ushort extract_16(BitSpan src)
            => BitSpan.extract<ushort>(src);

        public static uint extract_32(BitSpan src)
            => BitSpan.extract<uint>(src);

        public static ulong extract_64(BitSpan src)
            => BitSpan.extract<ulong>(src);

        public static byte bitslice_8(BitSpan src, int offset, int count)
            => BitSpan.bitslice<byte>(src,offset,count);

        public static ushort bitslice_16(BitSpan src, int offset, int count)
            => BitSpan.bitslice<ushort>(src,offset,count);

        public static uint bitslice_32(BitSpan src, int offset, int count)
            => BitSpan.bitslice<uint>(src,offset,count);

        public static ulong bitslice_64(BitSpan src, int offset, int count)
            => BitSpan.bitslice<ulong>(src,offset,count);

        public static ref readonly BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
            => ref BitSpan.and(x,y,z);
            
        public static ref readonly BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
            => ref BitSpan.xor(x,y,z);
    }

}