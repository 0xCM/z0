//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static refs;

    partial class math
    {
        /// <summary>
        /// Computes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgz]
        public static byte avgz(byte a, byte b)
            => (byte)((a & b) + ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgz]
        public static ushort avgz(ushort a, ushort b)
            => (ushort)((a & b) + ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgz]
        public static uint avgz(uint a, uint b)
            => (a & b) + ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgz]
        public static ulong avgz(ulong a, ulong b)
            => (a & b) + ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgi]
        public static byte avgi(byte a, byte b)
            => (byte)((a | b) - ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgi]
        public static ushort avgi(ushort a, ushort b)
            => (ushort)((a | b) - ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgi]
        public static uint avgi(uint a, uint b)
            => (a | b) - ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline), Avgi]
        public static ulong avgi(ulong a, ulong b)
            => (a | b) - ((a ^ b) >> 1);

        [MethodImpl(Inline), Avg]
        public static sbyte avg(ReadOnlySpan<sbyte> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static byte avg(ReadOnlySpan<byte> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static short avg(ReadOnlySpan<short> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static ushort avg(ReadOnlySpan<ushort> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static int avg(ReadOnlySpan<int> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static uint avg(ReadOnlySpan<uint> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static long avg(ReadOnlySpan<long> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static ulong avg(ReadOnlySpan<ulong> src, bool @checked)
            => @checked? avg_checked(src) : avg_unchecked(src);

        [MethodImpl(Inline), Avg]
        public static sbyte avg(ReadOnlySpan<sbyte> src)
            => avg(src,true);

        [MethodImpl(Inline), Avg]
        public static byte avg(ReadOnlySpan<byte> src)
            => avg(src,true);

        [MethodImpl(Inline), Avg]
        public static short avg(ReadOnlySpan<short> src)
            => avg(src,true);

        [MethodImpl(Inline), Avg]
        public static ushort avg(ReadOnlySpan<ushort> src)
            => avg(src,true);

        [MethodImpl(Inline), Avg]
        public static int avg(ReadOnlySpan<int> src)
            => avg(src,true);

        [MethodImpl(Inline), Avg]
        public static uint avg(ReadOnlySpan<uint> src)
            => avg(src,true);


        [MethodImpl(Inline), Avg]
        public static long avg(ReadOnlySpan<long> src)
            => avg(src,true);

        [MethodImpl(Inline), Avg]
        public static ulong avg(ReadOnlySpan<ulong> src)
            => avg(src,true);

        [MethodImpl(Inline), Op]
        static sbyte avg_unchecked(ReadOnlySpan<sbyte> src)
        {
            unchecked
            {
                var sum = default(long);
                
                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);
                
                return (sbyte)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline), Op]
        static byte avg_unchecked(ReadOnlySpan<byte> src)
        {
            unchecked
            {
                var sum = default(ulong);

                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);

                return (byte)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline), Op]
        static short avg_unchecked(ReadOnlySpan<short> src)
        {
            unchecked
            {
                var sum = default(long);
                
                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);
                
                return (short)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline), Op]
        static ushort avg_unchecked(ReadOnlySpan<ushort> src)
        {
            unchecked
            {
                var sum = default(ulong);

                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);

                return (ushort)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline), Op]
        static int avg_unchecked(ReadOnlySpan<int> src)
        {
            unchecked
            {
                var sum = default(long);
                
                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);
                
                return (int)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline), Op]
        static uint avg_unchecked(ReadOnlySpan<uint> src)
        {
            unchecked 
            {
                var sum = default(ulong);
                
                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);
                
                return (uint)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline), Op]
        static long avg_unchecked(ReadOnlySpan<long> src)
        {
            unchecked
            {
                var sum = default(long);

                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);

                return sum/src.Length;
            }
        }

        [MethodImpl(Inline), Op]
        static ulong avg_unchecked(ReadOnlySpan<ulong> src)
        {
            unchecked
            {
                var sum = default(ulong);

                ref readonly var current = ref head(src);                
                for(var i=0; i<src.Length; i++)
                    sum += skip(current,i);

                return sum/(ulong)src.Length;
            }
        }

        [MethodImpl(Inline), Op]
        static sbyte avg_checked(ReadOnlySpan<sbyte> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static byte avg_checked(ReadOnlySpan<byte> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static short avg_checked(ReadOnlySpan<short> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static ushort avg_checked(ReadOnlySpan<ushort> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static int avg_checked(ReadOnlySpan<int> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static uint avg_checked(ReadOnlySpan<uint> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static long avg_checked(ReadOnlySpan<long> src)
            {checked{ return avg_unchecked(src);}}

        [MethodImpl(Inline), Op]
        static ulong avg_checked(ReadOnlySpan<ulong> src)
            {checked{ return avg_unchecked(src);}}     
   }
}