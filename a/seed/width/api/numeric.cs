//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Widths
    {        
        [MethodImpl(Inline)]
        public static sbyte int8<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (sbyte)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static byte uint8<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (byte)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static short int16<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (short)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static ushort uint16<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (ushort)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static int int32<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (int)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static uint uint32<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (uint)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static long int64<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (long)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static ulong uint64<W>(W w = default)
            where W : unmanaged, ITypeWidth
                => (ulong)default(W).TypeWidth;          
    }
}