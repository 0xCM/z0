//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static AsmInstructions;

    using llvm;

    using static Root;
    using static core;
    using static llvm.MC;
    using static llvm.MC.AsmId;

    partial class AsmMetaSpecs
    {
        [Op]
        public static uint collect(in Movzx x, ref uint i, Span<AsmInfo> dst)
        {
            var i0 = i;
            // MOVZX r16, r/m8
            movzx(M.r16(), M.r8(), ref seek(dst, i++));
            movzx(M.r16(), M.m8(), ref seek(dst, i++));

            // MOVZX r32, r/m8
            movzx(M.r32(), M.r8(), ref seek(dst, i++));
            movzx(M.r32(), M.m8(), ref seek(dst, i++));

            // MOVZX r32, r/m16
            movzx(M.r32(), M.r16(), ref seek(dst, i++));
            movzx(M.r32(), M.m16(), ref seek(dst, i++));

            // MOVZX r64, r/m8
            movzx(M.r64(), M.r8(), ref seek(dst, i++));
            movzx(M.r64(), M.m8(), ref seek(dst, i++));

            //MOVZX r64, r/m16
            movzx(M.r64(), M.r16(), ref seek(dst, i++));
            movzx(M.r64(), M.m16(), ref seek(dst, i++));

            return i - i0;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r16 dst, r8 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX16rr8;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r16, r8";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r16 dst, m8 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX16rm8;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r16, m8";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r32 dst, r8 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX32rr8;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r32, r8";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r32 dst, m8 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX32rm8;
            const string OpCodeExpr = "0F B6 /r";
            const string SigExpr = "MOVZX r32, m8";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r32 dst, r16 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX32rr16;
            const string OpCodeExpr = "0F B7 /r";
            const string SigExpr = "MOVZX r32, r16";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r32 dst, m16 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX32rm16;
            const string OpCodeExpr = "0F B7 /r";
            const string SigExpr = "MOVZX r32, m16";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r64 dst, m8 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX64rm8;
            const string OpCodeExpr = "REX.W + 0F B6 /r";
            const string SigExpr = "MOVZX r64, m8";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r64 dst, r8 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX64rr8;
            const string OpCodeExpr = "REX.W + 0F B6 /r";
            const string SigExpr = "MOVZX r64, r8";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r64 dst, r16 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX64rr16;
            const string OpCodeExpr = "REX.W + 0F B7 /r";
            const string SigExpr = "MOVZX r64, r16";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }

        [MethodImpl(Inline), Op]
        public static void movzx(r64 dst, m16 src, ref AsmInfo info)
        {
            const AsmId Id = MOVZX64rm16;
            const string OpCodeExpr = "REX.W + 0F B7 /r";
            const string SigExpr = "MOVZX r64, m16";
            info.Id = Id;
            info.SigExpr = SigExpr;
            info.OpCodeExpr = OpCodeExpr;
        }
    }
}