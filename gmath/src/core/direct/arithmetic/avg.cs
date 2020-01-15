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
        /// <summary>
        /// Computes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static byte avgz(byte a, byte b)
            => (byte)((a & b) + ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static ushort avgz(ushort a, ushort b)
            => (ushort)((a & b) + ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static uint avgz(uint a, uint b)
            => (a & b) + ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static ulong avgz(ulong a, ulong b)
            => (a & b) + ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static byte avgi(byte a, byte b)
            => (byte)((a | b) - ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static ushort avgi(ushort a, ushort b)
            => (ushort)((a | b) - ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static uint avgi(uint a, uint b)
            => (a | b) - ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Op]
        public static ulong avgi(ulong a, ulong b)
            => (a | b) - ((a ^ b) >> 1);

    
        [MethodImpl(Inline)]
        internal static sbyte avg_unchecked(ReadOnlySpan<sbyte> src)
        {
            unchecked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (sbyte)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static byte avg_unchecked(ReadOnlySpan<byte> src)
        {
            unchecked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (byte)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static short avg_unchecked(ReadOnlySpan<short> src)
        {
            unchecked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (short)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static ushort avg_unchecked(ReadOnlySpan<ushort> src)
        {
            unchecked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return (ushort)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static int avg_unchecked(ReadOnlySpan<int> src)
        {
            unchecked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (int)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static uint avg_unchecked(ReadOnlySpan<uint> src)
        {
            unchecked 
            {
                var sum = default(ulong);
                
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                
                return (uint)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static long avg_unchecked(ReadOnlySpan<long> src)
        {
            unchecked
            {
                var sum = default(long);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/src.Length;
            }
        }

        [MethodImpl(Inline)]
        internal static ulong avg_unchecked(ReadOnlySpan<ulong> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/(ulong)src.Length;
            }
        }

        [MethodImpl(Inline)]
        internal static sbyte avg_checked(ReadOnlySpan<sbyte> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (sbyte)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static byte avg_checked(ReadOnlySpan<byte> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (byte)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static short avg_checked(ReadOnlySpan<short> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (short)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static ushort avg_checked(ReadOnlySpan<ushort> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return (ushort)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static int avg_checked(ReadOnlySpan<int> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (int)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static uint avg_checked(ReadOnlySpan<uint> src)
        {
            checked 
            {
                var sum = default(ulong);
                
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                
                return (uint)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static long avg_checked(ReadOnlySpan<long> src)
        {
            checked
            {
                var sum = default(long);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/src.Length;
            }
        }

        [MethodImpl(Inline)]
        internal static ulong avg_checked(ReadOnlySpan<ulong> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/(ulong)src.Length;
            }
        }

    }
}