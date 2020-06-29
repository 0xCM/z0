//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using D = Dsl;

    partial class asm
    {
        [MethodImpl(Inline)]
        public static D.r8<R> reg<R>(byte data, R r = default)
            where R : unmanaged, IRegOp8                
                => new D.r8<R>(data);

        [MethodImpl(Inline)]
        public static D.r16<R> reg<R>(ushort data, R r = default)
            where R : unmanaged, IRegOp16                
                => new D.r16<R>(data);

        [MethodImpl(Inline)]
        public static D.r32<R> reg<R>(uint data, R n = default)
            where R : unmanaged, IRegOp32                
                => new D.r32<R>(data);

        [MethodImpl(Inline)]
        public static D.r64<R> reg<R>(ulong data, R n = default)
            where R : unmanaged, IRegOp64
                => new D.r64<R>(data);

        [MethodImpl(Inline)]
        public static D.xmm<R> reg<R>(Fixed128 data, R r = default)
            where R : unmanaged, IRegOp128
                => new D.xmm<R>(data);

        [MethodImpl(Inline)]
        public static D.ymm<R> reg<R>(Fixed256 data, R n = default)
            where R : unmanaged, IRegOp256
                => new D.ymm<R>(data);
    }
}