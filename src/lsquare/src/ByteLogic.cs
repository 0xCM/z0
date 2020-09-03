// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Konst;
//     using static memory;

//     [ApiHost]
//     public class ByteLogic
//     {
//         [MethodImpl(Inline), Not]
//         public static void not(in byte A, ref byte Z)
//             => store64(math.not(read64(A)), ref Z);

//         [MethodImpl(Inline), Select]
//         public static void select(in byte A, in byte B, in byte C, ref byte Z)
//             => store64(math.select(read64(A), read64(B), read64(C)), ref Z);

//         [MethodImpl(Inline), And]
//         public static void and(in byte A, in byte B, ref byte Z)
//             => store64(math.and(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), Nand]
//         public static void nand(in byte A, in byte B, ref byte Z)
//             => store64(math.nand(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), Or]
//         public static void or(in byte A, in byte B, ref byte Z)
//             => store64(math.or(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), Nor]
//         public static void nor(in byte A, in byte B, ref byte Z)
//             => store64(math.nor(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), Xor]
//         public static void xor(in byte A, in byte B, ref byte Z)
//             => store64(math.xor(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), Xnor]
//         public static void xnor(in byte A, in byte B, ref byte Z)
//             => store64(math.xnor(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), NonImpl]
//         public static void nonimpl(in byte A, in byte B, ref byte Z)
//             => store64(math.nonimpl(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), Impl]
//         public static void impl(in byte A, in byte B, ref byte Z)
//             => store64(math.impl(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), CImpl]
//         public static void cimpl(in byte A, in byte B, ref byte Z)
//             => store64(math.cimpl(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), CNonImpl]
//         public static void cnonimpl(in byte A, in byte B, ref byte Z)
//             => store64(math.cnonimpl(read64(A), read64(B)), ref Z);

//         [MethodImpl(Inline), XorNot]
//         public static void xornot(in byte A, in byte B, ref byte Z)
//             => store64(math.xor(read64(A), math.not(read64(B))), ref Z);

//         [MethodImpl(Inline), TestZ]
//         public static bit testz(in byte A, in byte B)
//             => z.testz(read64(A), read64(B));

//         [MethodImpl(Inline), TestC]
//         public static bit testc(in byte A, in byte B)
//             => z.testc(read64(A),read64(B));

//         [MethodImpl(Inline), TestC]
//         public static bit testc(in byte A)
//             => z.testc(read64(A));
//     }
// }