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

    using static Konst;
    using static z;

    partial struct BitLogic
    {
        [ApiHost(ApiNames.BitLogicScalar, true)]
        public readonly struct Scalar
        {
            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static sbyte left(sbyte a, sbyte b)
                => a;

            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static byte left(byte a, byte b)
                => a;

            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static short left(short a, short b)
                => a;

            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static ushort left(ushort a, ushort b)
                => a;

            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static int left(int a, int b)
                => a;

            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static uint left(uint a, uint b)
                => a;

            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static long left(long a, long b)
                => a;

            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static ulong left(ulong a, ulong b)
                => a;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static sbyte right(sbyte a, sbyte b)
                => b;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static byte right(byte a, byte b)
                => b;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static short right(short a, short b)
                => b;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static ushort right(ushort a, ushort b)
                => b;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static int right(int a, int b)
                => b;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static uint right(uint a, uint b)
                => b;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static long right(long a, long b)
                => b;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static ulong right(ulong a, ulong b)
                => b;

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
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static sbyte not(sbyte src)
                => (sbyte)(~ src);

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static byte not(byte src)
                => (byte)(~ src);

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static short not(short src)
                => (short)(~ src);

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static ushort not(ushort src)
                => (ushort)(~ src);

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static int not(int src)
                => ~ src;

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static uint not(uint src)
                => ~ src;

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static long not(long src)
                => ~ src;

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static ulong not(ulong src)
                => ~ src;

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static sbyte and(sbyte a, sbyte b)
                => (sbyte)(a & b);

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static byte and(byte a, byte b)
                => (byte)(a & b);

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static short and(short a, short b)
                => (short)(a & b);

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static ushort and(ushort a, ushort b)
                => (ushort)(a & b);

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static int and(int a, int b)
                => a & b;

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static uint and(uint a, uint b)
                => a & b;

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static long and(long a, long b)
                => a & b;

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static ulong and(ulong a, ulong b)
                => a & b;

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static sbyte or(sbyte a, sbyte b)
                => (sbyte)(a | b);

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static byte or(byte a, byte b)
                => (byte)(a | b);

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static short or(short a, short b)
                => (short)(a | b);

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static ushort or(ushort a, ushort b)
                => (ushort)(a | b);

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static int or(int a, int b)
                => a | b;

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static uint or(uint a, uint b)
                => a | b;

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static long or(long a, long b)
                => a | b;

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static ulong or(ulong a, ulong b)
                => a | b;

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
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static sbyte xor(sbyte a, sbyte b)
                => (sbyte)(a ^ b);

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static byte xor(byte a, byte b)
                => (byte)(a ^ b);

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static short xor(short a, short b)
                => (short)(a ^ b);

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static ushort xor(ushort a, ushort b)
                => (ushort)(a ^ b);

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static int xor(int a, int b)
                => a ^ b;

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static uint xor(uint a, uint b)
                => a ^ b;

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static long xor(long a, long b)
                => a ^ b;

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static ulong xor(ulong a, ulong b)
                => a ^ b;

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static sbyte xnor(sbyte a, sbyte b)
                => not(xor(a,b));

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static byte xnor(byte a, byte b)
                => not(xor(a,b));

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static short xnor(short a, short b)
                => not(xor(a,b));

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static ushort xnor(ushort a, ushort b)
                => not(xor(a,b));

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static int xnor(int a, int b)
                => ~ (a ^ b);

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static uint xnor(uint a, uint b)
                => ~ (a ^ b);

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static long xnor(long a, long b)
                => ~ (a ^ b);

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static ulong xnor(ulong a, ulong b)
                => ~ (a ^ b);

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

            [MethodImpl(Inline), Op]
            public static sbyte blend(sbyte a, sbyte b, sbyte mask)
                => xor(a, and(xor(a,b), mask));

            [MethodImpl(Inline), Op]
            public static byte blend(byte a, byte b, byte mask)
                => xor(a, and(xor(a,b), mask));

            [MethodImpl(Inline), Op]
            public static short blend(short a, short b, short mask)
                => xor(a, and(xor(a,b), mask));

            [MethodImpl(Inline), Op]
            public static ushort blend(ushort a, ushort b, ushort mask)
                => xor(a, and(xor(a,b), mask));

            [MethodImpl(Inline), Op]
            public static int blend(int a, int b, int mask)
                => xor(a, and(xor(a,b), mask));

            [MethodImpl(Inline), Op]
            public static uint blend(uint a, uint b, uint mask)
                => xor(a, and(xor(a,b), mask));

            [MethodImpl(Inline), Op]
            public static long blend(long a, long b, long mask)
                => xor(a, and(xor(a,b), mask));

            [MethodImpl(Inline), Op]
            public static ulong blend(ulong a, ulong b,ulong mask)
                => xor(a, and(xor(a,b), mask));
        }
    }
}