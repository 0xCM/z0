//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Root;

    partial class Converter
    {
        [MethodImpl(Inline)]
        static double to64f(sbyte src)        
            => src;

        [MethodImpl(Inline)]
        static double to64f(byte src)        
            => src;
        
        [MethodImpl(Inline)]
        static double to64f(short src)        
            => src;

        [MethodImpl(Inline)]
        static double to64f(ushort src)        
            => src;

        [MethodImpl(Inline)]
        static double to64f(int src)        
            => src;

        [MethodImpl(Inline)]
        static double to64f(uint src)        
            => (long)src;

        [MethodImpl(Inline)]
        static double to64f(long src)        
            => src;

        [MethodImpl(Inline)]
        static double to64f(ulong src)        
            => (long)src;

        [MethodImpl(Inline)]
        static uint to32u(float src)        
            => (uint)((long)src);

        [MethodImpl(Inline)]
        static double to64f(float src)        
            => src;

        [MethodImpl(Inline)]
        static ulong to64u(float src)        
            => (ulong)((long)src);

        [MethodImpl(Inline)]
        static sbyte to8i(double src)
            => (sbyte)to32i(src);

        [MethodImpl(Inline)]
        static byte to8u(double src)
            => (byte)to32u(src);

        [MethodImpl(Inline)]
        static short to16i(double src)
            => (sbyte)to32i(src);

        [MethodImpl(Inline)]
        static ushort to16u(double src)
            => (ushort)to32u(src);

        [MethodImpl(Inline)]
        static unsafe int to32i(double src)
            => (int)src; 

        [MethodImpl(Inline)]
        static uint to32u(double src)
            => (uint)((long)src);

        [MethodImpl(Inline)]
        static long to64i(double src)
            => (long)src;

        [MethodImpl(Inline)]
        static unsafe ulong to64u(double src)
            => (ulong)((long)src);
    }
}