//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmInstructions;
    using static AsmOperands;
    using static AsmCodes;
    using static core;

    partial struct AsmEncodings
    {
        [ApiHost("encodings.jumps")]
        public readonly partial struct Jumps
        {
            [MethodImpl(Inline), Op]
            public static AsmHexCode jo(Hex8 cb)
            {
                const byte OpCode = 0x70;
                var dst = new AsmHexCode(OpCode);
                dst[1] = cb;
                dst[15] = 2;
                return dst;
            }

            [MethodImpl(Inline), Op]
            public static AsmHexCode jo(Hex32 cb)
            {
                const ushort OpCode = 0x7080;
                var dst = new AsmHexCode(OpCode);
                ref var x = ref seek(dst.Bytes,1);
                ref var y = ref @as<byte,Hex32>(x);
                y = cb;
                dst[15] = 6;
                return dst;
            }

            /// <summary>
            /// Jump short, RIP = RIP + 8-bit displacement sign extended to 64-bits
            /// </summary>
            /// <param name="w">The relative width selector</param>
            /// <param name="rip">The address of the first instruction following the callsite</param>
            /// <param name="dst">The target address</param>
            [MethodImpl(Inline), Op]
            public static AsmHexCode rel8(MemoryAddress rip, MemoryAddress dst)
            {
                const byte OpCode = 0xE8;
                const byte Size = 2;
                var opcode = OpCode;
                var encoded = AsmHexCode.Empty;
                var bytes = encoded.Bytes;
                seek(bytes,0) = opcode;
                u8(seek(bytes, 1)) = asm.disp8(rip,dst);
                seek(bytes, 15) = Size;
                return encoded;
            }

            /// <summary>
            /// Jump near, relative, RIP = RIP + 32-bit displacement sign extended to 64-bits
            /// </summary>
            /// <param name="w">The relative width selector</param>
            /// <param name="rip">The address of the first instruction following the callsite</param>
            /// <param name="dst">The target address</param>
            [MethodImpl(Inline), Op]
            public static AsmHexCode rel32(MemoryAddress rip, MemoryAddress dst)
            {
                const byte OpCode = 0xE9;
                const byte Size = 5;
                var opcode = OpCode;
                var encoded = AsmHexCode.Empty;
                var bytes = encoded.Bytes;
                seek(bytes, 0) = opcode;
                u32(seek(bytes, 1)) = asm.disp32(rip,dst);
                seek(bytes,15) = Size;
                return encoded;
            }

            /// <summary>
            /// Jump near, absolute indirect, RIP = 64-Bit offset from register or memory
            /// JMP r/m64 | FF /4
            /// jmp r64(FF /4)
            /// </summary>
            /// <param name="r"></param>
            [MethodImpl(Inline), Op]
            public static AsmHexCode absolute(r64 r)
            {
                var i = r.Index;

                return default;
            }
        }
    }
}