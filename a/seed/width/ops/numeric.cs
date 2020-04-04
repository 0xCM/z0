//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using K = NumericWidth;

    partial class Widths
    {        
        /// <summary>
        /// Computes the literal numeric width from a parametric width
        /// </summary>
        /// <typeparam name="W">The parametric width</typeparam>
        [MethodImpl(Inline)]
        public static K numeric<W>(W w = default)
            where W : struct, INumericWidth
        {
            if(typeof(W) == typeof(W1))
                return K.W1;
            else if(typeof(W) == typeof(W8))
                return K.W8;
            else if(typeof(W) == typeof(W16))
                return K.W16;
            else if(typeof(W) == typeof(W32))
                return K.W32;
            else if(typeof(W) == typeof(W64))
                return K.W64;
            else 
                return 0;
        }

        [MethodImpl(Inline)]
        public static sbyte int8<W>(W w = default)
            where W : struct, INumericWidth
                => (sbyte)numeric(w);

        [MethodImpl(Inline)]
        public static byte uint8<W>(W w = default)
            where W : struct, INumericWidth
                => (byte)numeric(w);

        [MethodImpl(Inline)]
        public static short int16<W>(W w = default)
            where W : struct, INumericWidth
                => (short)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static ushort uint16<W>(W w = default)
            where W : struct, INumericWidth
                => (ushort)numeric(w);

        [MethodImpl(Inline)]
        public static int int32<W>(W w = default)
            where W : struct, INumericWidth
                => (int)numeric(w);

        [MethodImpl(Inline)]
        public static uint uint32<W>(W w = default)
            where W : struct, INumericWidth
                => (uint)default(W).TypeWidth;         

        [MethodImpl(Inline)]
        public static long int64<W>(W w = default)
            where W : struct, INumericWidth
                => (long)numeric(w);

        [MethodImpl(Inline)]
        public static ulong uint64<W>(W w = default)
            where W : struct, INumericWidth
                => (ulong)numeric(w);
    }
}