//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        public interface reg32 : reg<W32>
        {
            const uint Width = 32;
        }

        public interface reg32<S> : reg32, reg<W32,S>
            where S : unmanaged
        {

        }

        public interface reg32<F,N,S> : reg32<S>, IIndexed<N>
            where F : unmanaged, reg32<F,N,S>
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {

        }


        public interface reg32<F,N> : reg16<F,N,Fixed32>
            where F : unmanaged, reg32<F,N>
            where N : unmanaged, ITypeNat
        {

        }

    }
}