//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static gcpu;
    using static MemBlocks;

    [ApiHost]
    public readonly struct AsmHexCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0)
        {
            var storage = block(n16).Bytes;
            seek(storage,0) = a0;
            return new AsmHexCode(vload<byte>(w128, storage));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1)
        {
            var storage = block(n16);
            ref var dst = ref MemBlocks.first8(storage);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            return new AsmHexCode(vload<byte>(w128, dst));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Imm8 a1)
        {
            var storage = block(n16);
            ref var dst = ref MemBlocks.first8(storage);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            return new AsmHexCode(vload<byte>(w128, dst));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex16 a0)
        {
            var storage = block(n16).Bytes;
            seek16(storage,0) = a0;
            return new AsmHexCode(vload<byte>(w128, storage));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex8 a2)
        {
            var storage = block(n16).Bytes;
            seek(storage,0) = a0;
            seek(storage,1) = a1;
            seek(storage,2) = a2;
            return new AsmHexCode(vload<byte>(w128, storage));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex8 a2, Hex8 a4)
        {
            var storage =block(n16);
            ref var dst = ref MemBlocks.first8(storage);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            seek(dst,2) = a2;
            seek(dst,4) = a4;
            return new AsmHexCode(vload<byte>(w128, dst));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhexdefine(Hex8 a0, Hex8 a1, Hex16 a2)
        {
            var storage = block(n16).Bytes;
            seek(storage,0) = a0;
            seek(storage,1) = a1;
            seek16(storage,2) = a2;
            return new AsmHexCode(vload<byte>(w128, storage));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex32 a1)
        {
            var storage = block(n16).Bytes;
            seek(storage,0) = a0;
            seek32(storage,1) = a1;
            return new AsmHexCode(vload<byte>(w128, storage));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex32 a2)
        {
            var storage = block(n16).Bytes;
            seek(storage,0) = a0;
            seek(storage,1) = a1;
            seek32(storage,2) = a2;
            return new AsmHexCode(vload<byte>(w128, storage));
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, ulong a2)
        {
            var storage = block(n16).Bytes;
            seek(storage,0) = a0;
            seek(storage,1) = a1;
            seek64(storage,2) = a2;
            return new AsmHexCode(vload<byte>(w128, storage));
        }
    }
}