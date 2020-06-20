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
        public static D.r8<N> reg<N>(byte value, N n = default)
            where N : unmanaged, ITypeNat
                => new D.r8<N>(value);

        [MethodImpl(Inline)]
        public static D.r16<N> reg<N>(ushort value, N n = default)
            where N : unmanaged, ITypeNat
                => new D.r16<N>(value);

        [MethodImpl(Inline)]
        public static D.r32<N> reg<N>(uint value, N n = default)
            where N : unmanaged, ITypeNat
                => new D.r32<N>(value);

        [MethodImpl(Inline)]
        public static D.r64<N> reg<N>(ulong value, N n = default)
            where N : unmanaged, ITypeNat
                => new D.r64<N>(value);

        [MethodImpl(Inline)]
        public static D.xmm<N> reg<N>(Fixed128 value, N n = default)
            where N : unmanaged, ITypeNat
                => new D.xmm<N>(value);

        [MethodImpl(Inline)]
        public static D.ymm<N> reg<N>(Fixed256 value, N n = default)
            where N : unmanaged, ITypeNat
                => new D.ymm<N>(value);

        [MethodImpl(Inline)]
        public static D.zmm<N> reg<N>(Fixed512 value, N n = default)
            where N : unmanaged, ITypeNat
                => new D.zmm<N>(value);
    }
}