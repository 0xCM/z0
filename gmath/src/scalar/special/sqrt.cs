//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;        
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static byte sqrt(byte src)
            => (byte)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static sbyte sqrt(sbyte src)
            => (sbyte)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static short sqrt(short src)
            => (short)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static ushort sqrt(ushort src)
            => (ushort)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static int sqrt(int src)
            => (int)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static uint sqrt(uint src)
            => (uint)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static long sqrt(long src)
            => (long)Math.Sqrt(src);

        [MethodImpl(Inline)]
        public static ulong sqrt(ulong src)
            => (ulong)Math.Sqrt(src);
    }
}