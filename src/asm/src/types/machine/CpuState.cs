//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly ref partial struct CpuState
    {
        readonly Span<Fixed64> GpBank;

        readonly Span<Fixed256V> VectorBank;

        public static CpuState Create(int vcount = 16)
            => new CpuState(vcount);

        CpuState(int vcount)
        {
            GpBank = new Fixed64[16];
            VectorBank = new Fixed256V[vcount];
        }

        [MethodImpl(Inline)]
        Span<V> v<V>()
            where V : unmanaged
            => VectorBank.As<Fixed256V,V>();

        [MethodImpl(Inline)]
        Span<G> gp<G>()
            where G : unmanaged
                => GpBank.As<Fixed64,G>();
    }
}