//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;

    using static As;
    using static zfunc;    

    public static class FloatConvert
    {
        [MethodImpl(Inline)]
        public static double to64f(sbyte src)        
            => src;//ConvertScalarToVector128Double(default, src).GetElement(0);

        [MethodImpl(Inline)]
        public static double to64f(byte src)        
            => src; //ConvertScalarToVector128Double(default, (int)src).GetElement(0);
        
        [MethodImpl(Inline)]
        public static double to64f(short src)        
            => src;//ConvertScalarToVector128Double(default, (int)src).GetElement(0);

        [MethodImpl(Inline)]
        public static double to64f(ushort src)        
            => src;//ConvertScalarToVector128Double(default, (int)src).GetElement(0);

        [MethodImpl(Inline)]
        public static double to64f(int src)        
            => src;// ConvertScalarToVector128Double(default, src).GetElement(0);

        [MethodImpl(Inline)]
        public static double to64f(uint src)        
            => (long)src;

        [MethodImpl(Inline)]
        public static double to64f(long src)        
            => src;

        [MethodImpl(Inline)]
        public static double to64f(ulong src)        
            => (long)src;

        [MethodImpl(Inline)]
        public static double to64f(float src)        
            => src;

        [MethodImpl(Inline)]
        public static sbyte to8i(double src)
            => (sbyte)to32i(src);

        [MethodImpl(Inline)]
        public static byte to8u(double src)
            => (byte)to32u(src);

        [MethodImpl(Inline)]
        public static short to16i(double src)
            => (sbyte)to32i(src);

        [MethodImpl(Inline)]
        public static ushort to16u(double src)
            => (ushort)to32u(src);

        [MethodImpl(Inline)]
        public static unsafe int to32i(double src)
            => (int)src; 

        [MethodImpl(Inline)]
        public static uint to32u(double src)
            => (uint)src;

        [MethodImpl(Inline)]
        public static long to64i(double src)
            => (long)src;

        [MethodImpl(Inline)]
        public static unsafe ulong to64u(double src)
            => (ulong)src;

    }


}