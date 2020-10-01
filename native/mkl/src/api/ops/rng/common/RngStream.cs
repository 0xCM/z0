//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MklRng : IRngSource,  IDisposable
    {
        [MethodImpl(Inline)]
        public static MklRng Define(Brng brng, uint seed = 0, int index = 0)
            =>  new MklRng(brng, seed, index);

        [MethodImpl(Inline)]
        internal MklRng(Brng brng, uint seed = 0, int index = 0)
        {
            this.Source = brng.NewStream(seed, index);
        }

        internal VslStream Source {get;}

        public RngKind RngKind
            => Source.RngKind();

        public void Dispose()
            => Source.Dispose();
    }
}