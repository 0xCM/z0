//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
    using static FixedContainers;
    using static StackContainers;
    partial class zfoc
    {

        public static void deposit(in ulong src, ref Fixed128 dst)
            => FixedStore.deposit(src, ref dst);

        public static void deposit_4_0(in uint src, ref Fixed128 dst)
            => FixedStore.deposit(src, 4, ref dst, 0);

        public static void deposit_2_2(in uint src, ref Fixed128 dst)
            => FixedStore.deposit(src, 2, ref dst, 2);

        public static Span<byte> bc_bytes_16u(ushort a)
            => BitConvert.GetBytes(a);

        public static Span<byte> bc_bytes_64u(ulong a)
            => BitConvert.GetBytes(a);

        public static Span<byte> bc_bytes_fixed256(Fixed256 a)
            => BitConvert.GetBytes(a);

        public static Span<byte> bc_bytes_fixed512(Fixed512 a)
            => BitConvert.GetBytes(a);

        public static Span<byte> bc_bytes_fixed1024(Fixed1024 a)
            => BitConvert.GetBytes(a);

        public static Span<byte> bc_bytes_fixed2048(Fixed2048 a)
            => BitConvert.GetBytes(a);

        public static Span<byte> bc_bytes_fixed4096(Fixed4096 a)
            => BitConvert.GetBytes(a);


    }

}