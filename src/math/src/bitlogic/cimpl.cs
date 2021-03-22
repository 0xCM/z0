//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    partial class math
    {
        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static sbyte @false(sbyte a, sbyte b)
            => 0;

        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static byte @false(byte a, byte b)
            => 0;

        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static short @false(short a, short b)
            => 0;

        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static ushort @false(ushort a, ushort b)
            => 0;

        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static int @false(int a, int b)
            => 0;

        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static uint @false(uint a, uint b)
            => 0;

        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static long @false(long a, long b)
            => 0;

        /// <summary>
        /// Returns 0, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static ulong @false(ulong a, ulong b)
            => 0;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static sbyte @true(sbyte a, sbyte b)
            => sbyte.MinValue;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static byte @true(byte a, byte b)
            => byte.MaxValue;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static short @true(short a, short b)
            => short.MinValue;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static ushort @true(ushort a, ushort b)
            => ushort.MaxValue;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static int @true(int a, int b)
            => int.MinValue;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static uint @true(uint a, uint b)
            => uint.MaxValue;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static long @true(long a, long b)
            => long.MinValue;

        /// <summary>
        /// Returns all 1's, irrespective of the operand values
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), False]
        public static ulong @true(ulong a, ulong b)
            => ulong.MaxValue;

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static sbyte cimpl(sbyte a, sbyte b)
            => or(not(a),b);

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static byte cimpl(byte a, byte b)
            => (byte)(~a | b);

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static short cimpl(short a, short b)
            => or(not(a),b);

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static ushort cimpl(ushort a, ushort b)
            => (ushort)(~a | b);

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static int cimpl(int a, int b)
            => ~a | b;

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static uint cimpl(uint a, uint b)
            => ~a | b;

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static long cimpl(long a, long b)
            => ~a | b;

        /// <summary>
        /// Computes the converse implication c := ~a | b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static ulong cimpl(ulong a, ulong b)
            => ~a | b;

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static sbyte cnonimpl(sbyte a, sbyte b)
            => (sbyte)AndNot((uint)b,(uint)a);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static byte cnonimpl(byte a, byte b)
            => (byte)AndNot((uint)b,(uint)a);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static short cnonimpl(short a, short b)
            => (short)AndNot((uint)b,(uint)a);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static ushort cnonimpl(ushort a, ushort b)
            => (ushort)AndNot((uint)b,(uint)a);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static int cnonimpl(int a, int b)
            => (int)AndNot((uint)b,(uint)a);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static uint cnonimpl(uint a, uint b)
            => AndNot(b,a);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static long cnonimpl(long a, long b)
            => (long)AndNot((ulong)b,(ulong)a);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static ulong cnonimpl(ulong a, ulong b)
            => AndNot(b,a);

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static sbyte impl(sbyte a, sbyte b)
            => (sbyte)((int)a | ~(int)b);

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static byte impl(byte a, byte b)
            => (byte)(a | ~b);

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static short impl(short a, short b)
            => (short)((int)a | ~(int)b);

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static ushort impl(ushort a, ushort b)
            => (ushort)(a | ~b);

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static int impl(int a, int b)
            => a | ~ b;

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static uint impl(uint a, uint b)
            => a | ~b;

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static long impl(long a, long b)
            => a | ~ b;

        /// <summary>
        /// Computes the material implication c := a | ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Impl]
        public static ulong impl(ulong a, ulong b)
            => a | ~b;

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static sbyte nand(sbyte a, sbyte b)
            => not(and(a,b));

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static byte nand(byte a, byte b)
            => not(and(a,b));

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static short nand(short a, short b)
            => not(and(a,b));

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static ushort nand(ushort a, ushort b)
            => not(and(a,b));

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static int nand(int a, int b)
            => ~ (a & b);

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static uint nand(uint a, uint b)
            => ~ (a & b);

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static long nand(long a, long b)
            => ~ (a & b);

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static ulong nand(ulong a, ulong b)
            => ~ (a & b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static sbyte nonimpl(sbyte a, sbyte b)
            => (sbyte)AndNot((uint)a,(uint)b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static byte nonimpl(byte a, byte b)
            => (byte)AndNot((uint)a,(uint)b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static short nonimpl(short a, short b)
            => (short)AndNot((uint)a,(uint)b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static ushort nonimpl(ushort a, ushort b)
            => (ushort)AndNot((uint)a,(uint)b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static int nonimpl(int a, int b)
            => (int)AndNot((uint)a,(uint)b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static uint nonimpl(uint a, uint b)
            => AndNot(a,b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static long nonimpl(long a, long b)
            => (long)AndNot((ulong)a,(ulong)b);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static ulong nonimpl(ulong a, ulong b)
            => AndNot(a,b);

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static sbyte nor(sbyte a, sbyte b)
            => not(or(a,b));

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static byte nor(byte a, byte b)
            => not(or(a,b));

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static short nor(short a, short b)
            => not(or(a,b));

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static ushort nor(ushort a, ushort b)
            => not(or(a,b));

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static int nor(int a, int b)
            => ~ (a | b);

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static uint nor(uint a, uint b)
            => ~ (a | b);

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static long nor(long a, long b)
            => ~ (a | b);

        /// <summary>
        /// Computes the bitwise nor c := ~(a | b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Nor]
        public static ulong nor(ulong a, ulong b)
            => ~ (a | b);


        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static sbyte lnot(sbyte a, sbyte b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static byte lnot(byte a, byte b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static short lnot(short a, short b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static ushort lnot(ushort a, ushort b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static int lnot(int a, int b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static uint lnot(uint a, uint b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static long lnot(long a, long b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the left operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), LNot]
        public static ulong lnot(ulong a, ulong b)
            => not(a);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static sbyte rnot(sbyte a, sbyte b)
            => not(b);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static byte rnot(byte a, byte b)
            => not(b);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static short rnot(short a, short b)
            => not(b);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static ushort rnot(ushort a, ushort b)
            => not(b);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static int rnot(int a, int b)
            => not(b);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static uint rnot(uint a, uint b)
            => not(b);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static long rnot(long a, long b)
            => not(b);

        /// <summary>
        /// Computes the bitwise not of the right operand
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), RNot]
        public static ulong rnot(ulong a, ulong b)
            => not(b);

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static sbyte select(sbyte a, sbyte b, sbyte c)
            => (sbyte)select((int)a, (int)b, (int)c);

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static byte select(byte a, byte b, byte c)
            => (byte)select((uint)a, (uint)b, (uint)c);

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static short select(short a, short b, short c)
            => (short)select((int)a, (int)b, (int)c);

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static ushort select(ushort a, ushort b, ushort c)
            => (ushort)select((uint)a, (uint)b, (uint)c);

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static int select(int a, int b, int c)
            => or(and(a,b), nonimpl(a,c));

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static uint select(uint a, uint b, uint c)
            => or(and(a,b), nonimpl(a,c));

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static long select(long a, long b, long c)
            => or(and(a,b), nonimpl(a,c));

        /// <summary>
        /// Computes the bitwise select of the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static ulong select(ulong a, ulong b, ulong c)
            => or(and(a,b), nonimpl(a,c));
    }
}