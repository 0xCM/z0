//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Scalar
    {
        [MethodImpl(Inline)]
        public static sbyte sar(sbyte src, byte offset)
            =>(sbyte)(src >> offset);

        [MethodImpl(Inline)]
        public static byte sar(byte src, byte offset)
            => (byte)(src >> offset);

        [MethodImpl(Inline)]
        public static short sar(short src, byte offset)
            => (short)(src >> offset);

        [MethodImpl(Inline)]
        public static ushort sar(ushort src, byte offset)
            => (ushort)(src >> offset);

        [MethodImpl(Inline)]
        public static int sar(int src, byte offset)
            => src >> offset;

        [MethodImpl(Inline)]
        public static uint sar(uint src, byte offset)
            => src >> offset;

        [MethodImpl(Inline)]
        public static long sar(long src, byte offset)
            => src >> offset;

        [MethodImpl(Inline)]
        public static ulong sar(ulong src, byte offset)
            => src >> offset;             
    }    
}