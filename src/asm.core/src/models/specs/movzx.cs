//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using llvm;

    using static Root;
    using static core;
    using static AsmOperands;
    using static llvm.MC;

    partial class AsmSpecs
    {
        /// <summary>
        /// | 0F B6 /r | MOVZX r16, r8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte movzx(r16 dst, r8 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.MOVZX16rr8;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r16, r8";
            const byte Size = 5;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;
            seek(hex,0) = AsmEncoder.modrm(dst.Index, src.Index, 0);
            seek(hex,1)  = 0xB6;
            seek(hex,2)  = 0x0F;
            seek(hex,3)  = 0x66;
            return Size;
        }

        /// <summary>
        /// | 0F B6 /r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte movzx(r16 dst, m8 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r16, m8";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
        }

        /// <summary>
        /// 0F B6 /r | MOVZX r32, r8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte movzx(r32 dst, r8 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r32, r8";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
        }

        /// <summary>
        /// 0F B6 /r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static byte movzx(r32 dst, m8 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r32, m8";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
        }

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, r8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte movzx(r64 dst, r8 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "REX.W + 0F B6 /r";
            const string SigExpr = "MOVZX r64, r8";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
        }

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static byte movzx(r64 dst, m8 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "REX.W + 0F B6 /r";
            const string SigExpr = "MOVZX r64, m8";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
        }

        /// <summary>
        /// 0F B7 /r | MOVZX r32, r16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte movzx(r32 dst, r16 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "0F B7 /r";
            const string SigExpr = "MOVZX r32, r16";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
        }

        /// <summary>
        /// 0F B7 /r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte movzx(r32 dst, m16 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "";
            const string SigExpr = "";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
        }

        /// <summary>
        /// REX.W + 0F B7 /r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static byte movzx(r64 dst, m16 src, ref byte hex, ref AsmId id, ref string sig, ref string oc)
        {
            const AsmId Id = AsmId.AAA;
            const string OpCodeExpr = "";
            const string SigExpr = "";
            const byte Size = 0;
            id = Id;
            sig = SigExpr;
            oc = OpCodeExpr;

            return Size;
       }
    }
}