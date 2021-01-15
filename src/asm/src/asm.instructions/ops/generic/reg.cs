//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;

    partial struct AsmBuilder
    {
        [MethodImpl(Inline)]
        public static r8 reg<R>(R r, byte pos, byte data = default)
            where R : unmanaged, IRegister
                => new r8(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static r16 reg<R>(R r, byte pos, ushort data)
            where R : unmanaged, IRegister
                => new r16(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static r32 reg<R>(R r, byte pos, uint data)
            where R : unmanaged, IRegister
                => new r32(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static r64 reg<R>(byte pos, ulong data, R r = default)
            where R : unmanaged, IRegister
                => new r64(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static xmm reg<R>(Cell128 data, R r = default)
            where R : unmanaged, IRegister
                => new xmm(data, r.Kind);

        [MethodImpl(Inline)]
        public static Ymm<R> reg<R>(Cell256 data, R n = default)
            where R : unmanaged, IRegister
                => new Ymm<R>(data);

        [MethodImpl(Inline)]
        public static Zmm<R> reg<R>(Cell512 data, R n = default)
            where R : unmanaged, IRegister
                => new Zmm<R>(data);
    }
}