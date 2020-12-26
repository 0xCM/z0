// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static sbyte min(sbyte a, sbyte b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static byte min(byte a, byte b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static short min(short a, short b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static ushort min(ushort a, ushort b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static int min(int a, int b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static uint min(uint a, uint b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static long min(long a, long b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static ulong min(ulong a, ulong b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static float min(float a, float b)
            => corefunc.min(a,b);

        [MethodImpl(Inline)]
        public static double min(double a, double b)
            => corefunc.min(a,b);
    }
}