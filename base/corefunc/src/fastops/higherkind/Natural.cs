//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class HK
    {

        [MethodImpl(Inline)]
        public static Natural nat()
                => default;

        [MethodImpl(Inline)]
        public static Natural<N> nat<N>(N n = default)        
            where N : unmanaged, ITypeNat
                => default;

        public readonly struct Natural : INatKind
        {
            public const TypeKind TypeClass = TypeKind.NatType; 
        }

        public readonly struct Natural<N> : INatKind<N>
            where N : unmanaged, ITypeNat
        {
            public const TypeKind TypeClass = TypeKind.NatType; 

            public ulong Value 
            {
                [MethodImpl(Inline)]
                get => nateval<N>();
            }
        }
    }

}