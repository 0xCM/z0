// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {            
        [MethodImpl(Inline)]
        public static sbyte min(sbyte a, sbyte b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static byte min(byte a, byte b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static short min(short a, short b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static ushort min(ushort a, ushort b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static int min(int a, int b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static uint min(uint a, uint b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static long min(long a, long b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static ulong min(ulong a, ulong b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static float min(float a, float b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static double min(double a, double b)
            => a < b ? a : b;
    }
}