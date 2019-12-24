//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        [MethodImpl(Inline)]
        public static byte avgz(byte a, byte b)
            => (byte)((a & b) + ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ushort avgz(ushort a, ushort b)
            => (ushort)((a & b) + ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static uint avgz(uint a, uint b)
            => (a & b) + ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ulong avgz(ulong a, ulong b)
            => (a & b) + ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero, and ovwriting the left operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref byte avgz(ref byte a, in byte b)
        {
            a = avgz(a,b);
            return ref a;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero, and ovwriting the first operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ushort avgz(ref ushort a, in ushort b)
        {
            a = avgz(a,b);
            return ref a;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero, and ovwriting the first operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref uint avgz(ref uint a, in uint b)
        {
            a = avgz(a,b);
            return ref a;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero, and ovwriting the first operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ulong avgz(ref ulong a, in ulong b)
        {
            a = avgz(a,b);
            return ref a;
        }

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static byte avgi(byte a, byte b)
            => (byte)((a | b) - ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ushort avgi(ushort a, ushort b)
            => (ushort)((a | b) - ((a ^ b) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static uint avgi(uint a, uint b)
            => (a | b) - ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ulong avgi(ulong a, ulong b)
            => (a | b) - ((a ^ b) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero, and ovwriting the left operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref byte avgi(ref byte a, in byte b)
        {
            a = avgi(a,b);
            return ref a;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero, and ovwriting the first operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ushort avgi(ref ushort a, in ushort b)
        {
            a = avgi(a,b);
            return ref a;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero, and ovwriting the first operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref uint avgi(ref uint a, in uint b)
        {
            a = avgi(a,b);
            return ref a;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero, and ovwriting the first operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ulong avgi(ref ulong a, in ulong b)
        {
            a = avgi(a,b);
            return ref a;
        }
    }
}