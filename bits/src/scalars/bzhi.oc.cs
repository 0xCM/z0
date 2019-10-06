//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class boc
    {

        public static byte bzhi_d8u(byte src, uint index)
            => Bits.bzhi(src,index);

        public static byte bzhi_g8u(byte src, uint index)
            => gbits.bzhi(src, index);

        public static ref byte bzhi_g8u_ref(ref byte src, uint index)
            => ref gbits.bzhi(ref src, index);

        public static ushort bzhi_d16u(ushort src, ushort index)
            => Bits.bzhi(src,index);

        public static ushort bzhi_g16u(ushort src, ushort index)
            => gbits.bzhi(src, index);

        public static ref ushort bzhi_g16u_ref(ref ushort src, ushort index)
            => ref gbits.bzhi(ref src, index);

        public static uint bzhi_d32u(uint src, uint index)
            => Bits.bzhi(src,index);

        public static uint bzhi_g32u(uint src, uint index)
            => gbits.bzhi(src, index);

        public static ref uint bzhi_g32u_ref(ref uint src, uint index)
            => ref gbits.bzhi(ref src, index);

        public static ulong bzhi_d64u(ulong src, uint index)
            => Bits.bzhi(src,index);

        public static ulong bzhi_g64u(ulong src, uint index)
            => gbits.bzhi(src,index);

        public static ref ulong bzhi_g64u_ref(ref ulong src, uint index)
            => ref gbits.bzhi(ref src,index);

    }

}