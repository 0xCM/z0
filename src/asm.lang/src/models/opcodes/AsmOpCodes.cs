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

    using L = LockPrefixCode;
    using REX = RexPrefixCode;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        public static AsmOpCode create()
            => new AsmOpCode();

        [MethodImpl(Inline), Op]
        public static AsmOpCode RexW(byte data)
        {
            var dst = create();
            dst.Byte0 = (byte)REX.Rex48;
            dst.Byte1 = data;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCode RexW(EscapeCode escape, byte data)
        {
            var dst = new AsmOpCode();
            dst.Byte0 = (byte)REX.Rex48;
            dst.Byte1 = (byte)escape;
            dst.Byte2 = data;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCode Lock(byte data)
        {
            var dst = create();
            dst.Byte0 = (byte)L.LOCK;
            dst.Byte1 = data;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCode Escape(EscapeCode escape, byte data)
        {
            var dst = create();
            dst.Byte0 = (byte)escape;
            dst.Byte1 = data;
            return dst;
        }
    }
}