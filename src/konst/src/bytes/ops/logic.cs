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
    using static memory;

    partial struct Bytes
    {
        [MethodImpl(Inline), Not]
        public static byte not(byte src)
            => (byte)(~ src);

        [MethodImpl(Inline), Not]
        public static void not(in byte A, ref byte Z)
            => store8(not(read8(A)), ref Z);

        [MethodImpl(Inline), And]
        public static void and(in byte A, in byte B, ref byte Z)
            => store8(and(read8(A), read8(B)), ref Z);

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c)
            => (byte)(a | b | c);

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c, byte d)
            => (byte)(a | b | c | d);

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c, byte d, byte e)

            => (byte)(a | b | c | d | e);      

        [MethodImpl(Inline), Or]
        public static void or(in byte A, in byte B, ref byte Z)
            => store8(or(read8(A), read8(B)), ref Z);

        [MethodImpl(Inline), Xor]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);

        [MethodImpl(Inline), Xor]
        public static void xor(in byte A, in byte B, ref byte Z)
            => store8(xor(read8(A), read8(B)), ref Z);

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), Nand]
        public static byte nand(byte a, byte b)
            => not(and(a,b));

        [MethodImpl(Inline), Nand]
        public static void nand(in byte A, in byte B, ref byte Z)
            => store8(nand(read8(A), read8(B)), ref Z);
            
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
        /// and deposits the result to a reference-identified location
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Nor]
        public static void nor(in byte a, in byte b, ref byte dst)
            => store8(nor(read8(a), read8(b)), ref dst);

        [MethodImpl(Inline), Xnor]
        public static byte xnor(byte a, byte b)
            => not(xor(a,b));

        [MethodImpl(Inline), Xnor]
        public static void xnor(in byte A, in byte B, ref byte Z)
            => store8(xnor(read8(A), read8(B)), ref Z);

        /// <summary>
        /// Computes the material nonimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), NonImpl]
        public static byte nonimpl(byte a, byte b)
            => (byte)AndNot((uint)a,(uint)b);

        [MethodImpl(Inline), NonImpl]
        public static void nonimpl(in byte A, in byte B, ref byte Z)
            => store8(nonimpl(read8(A), read8(B)), ref Z);

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
        /// and deposits the result to a reference-identified location
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Impl]
        public static void impl(in byte a, in byte b, ref byte dst)
            => store8(impl(read8(a), read8(b)), ref dst);

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
        /// and deposits the result to a reference-identified location
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), CImpl]
        public static void cimpl(in byte A, in byte B, ref byte Z)
            => store8(cimpl(read8(A), read8(B)), ref Z);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), CNonImpl]
        public static byte cnonimpl(byte a, byte b)
            => (byte)AndNot((uint)b,(uint)a);

        [MethodImpl(Inline), CNonImpl]
        public static void cnonimpl(in byte A, in byte B, ref byte Z)
            => store8(cnonimpl(read8(A), read8(B)), ref Z);

        [MethodImpl(Inline), XorNot]
        public static void xornot(in byte A, in byte B, ref byte Z)
            => store8(xor(read8(A), not(read8(B))), ref Z);

        /// <summary>
        /// Computes the bitwise select among the operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Select]
        public static byte select(byte a, byte b, byte c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline), Select]
        public static void select(in byte A, in byte B, in byte C, ref byte Z)
            => store8(select(read8(A), read8(B), read8(C)), ref Z);
    }
}