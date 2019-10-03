//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;

    partial class math
    {
        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static byte avgz(byte lhs, byte rhs)
            => (byte)((lhs & rhs) + ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ushort avgz(ushort lhs, ushort rhs)
            => (ushort)((lhs & rhs) + ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static uint avgz(uint lhs, uint rhs)
            => (lhs & rhs) + ((lhs ^ rhs) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ulong avgz(ulong lhs, ulong rhs)
            => (lhs & rhs) + ((lhs ^ rhs) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero and
        /// ovwriting the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref byte avgz(ref byte lhs, in byte rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero and ovwriting the 
        /// first operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ushort avgz(ref ushort lhs, in ushort rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero and ovwriting the 
        /// first operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref uint avgz(ref uint lhs, in uint rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero and ovwriting the 
        /// first operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ulong avgz(ref ulong lhs, in ulong rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static byte avgi(byte lhs, byte rhs)
            => (byte)((lhs | rhs) - ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ushort avgi(ushort lhs, ushort rhs)
            => (ushort)((lhs | rhs) - ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static uint avgi(uint lhs, uint rhs)
            => (lhs | rhs) - ((lhs ^ rhs) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ulong avgi(ulong lhs, ulong rhs)
            => (lhs | rhs) - ((lhs ^ rhs) >> 1);

    }
}