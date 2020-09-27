//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static R8<R> reg<R>(byte data, R r = default)
            where R : unmanaged, IRegister<R>
                => new R8<R>(data);

        [MethodImpl(Inline)]
        public static R16<R> reg<R>(ushort data, R r = default)
            where R : unmanaged, IReg16
                => new R16<R>(data);

        [MethodImpl(Inline)]
        public static R32<R> reg<R>(uint data, R n = default)
            where R : unmanaged, IReg32
                => new R32<R>(data);

        [MethodImpl(Inline)]
        public static R64<R> reg<R>(ulong data, R n = default)
            where R : unmanaged, IReg64
                => new R64<R>(data);

        [MethodImpl(Inline)]
        public static Xmm<R> reg<R>(Cell128 data, R r = default)
            where R : unmanaged, IXmmReg
                => new Xmm<R>(data);

        [MethodImpl(Inline)]
        public static Ymm<R> reg<R>(Cell256 data, R n = default)
            where R : unmanaged, IYmmReg
                => new Ymm<R>(data);
    }
}