//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static AsmOperands;
    using static core;

    public readonly struct AsmSigBits
    {

        public static uint mnemonic(ReadOnlySpan<char> src, ref uint i, Span<byte> dst)
        {
            var i0 = i;
            var count = src.Length;
            ref var b = ref seek(dst,i);
            for(var j = 0; j<count; j++)
            {
                ref readonly var c = ref skip(src,j);
            }
            return i - i0;
        }
    }


    [ApiHost]
    public partial class AsmOps
    {


        // public static AsmInstruction kmovd(rK dst, r32 src)
        // {

        // }

        // public static byte sig(ReadOnlySpan<char> name, AsmOpClass op0, Span<byte> dst)
        // {
        //     return default;
        // }


        /*

            cmp r8 imm8
            cmp m8 imm8
            cmp r16 imm16
            cmp m16 imm16
            cmp r32 imm32
            cmp m32 imm32
            cmp r64 imm32
            cmp m64 imm32
            cmp r16 imm8
            cmp m16 imm8
            cmp r32 imm8
            cmp m32 imm8
            cmp r64 imm8
            cmp m64 imm8
            cmp r8 r8
            cmp m8 r8
            cmp r16 r16
            cmp m16 r16
            cmp r32 r32
            cmp m32 r32
            cmp r64 r64
            cmp m64 r64

        */
    }
}