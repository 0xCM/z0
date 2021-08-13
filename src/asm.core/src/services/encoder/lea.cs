//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperands;
    using static Blit;

    partial struct AsmEncoder
    {
        /// <summary>
        /// LEA r16,m | 8D /r | encoding(ModRM:reg (w), ModRM:r/m (r))
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        /// <param name="hex">The encoded bytes</param>
        [MethodImpl(Inline), Op]
        public static byte lea(r16 dst, in AsmAddress src, ref byte hex)
        {
            var size = z8;

            return size;
        }


        /// <summary>
        /// LEA r32,m | 8D /r | encoding(ModRM:reg (w), ModRM:r/m (r))
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        /// <param name="hex">The encoded bytes</param>
        [MethodImpl(Inline), Op]
        public static byte lea(r32 dst, in AsmAddress src, ref byte hex)
        {
            // lea esi,[r11+1] | 41 8d 73 01
            // lea ecx,[rdx+1] | 8d 4a 01
            // lea eax,[r9-1]  | 41 8d 41 ff
            var size = z8;

            return size;
        }


        /// <summary>
        /// LEA r64,m | REX.W + 8D /r | encoding(ModRM:reg (w), ModRM:r/m (r))
        /// </summary>
        /// <param name="dst">The target operand</param>
        /// <param name="src">The source operand</param>
        /// <param name="hex">The encoded bytes</param>
        [MethodImpl(Inline), Op]
        public static byte lea(r64 dst, in AsmAddress src, ref byte hex)
        {
            // lea rcx,[rsi+8]    | 48 8d 4e 08
            // lea rcx,[rsi+10h]  | 48 8d 4e 10
            // lea rcx,[rsi+20h]  | 48 8d 4e 20
            // lea rcx,[rsi+90h]  | 48 8d 8e 90 00 00 00
            // lea rcx,[rsp+0b8h] | 48 8d 8c 24 b8 00 00 00
            var size = z8;

            return size;
        }

    }
}