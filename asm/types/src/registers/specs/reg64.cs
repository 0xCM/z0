//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        public interface reg64 : reg<W64>
        {
            const uint Width = 64;
        }

        public interface reg64<S> : reg64, reg<W64,S>
            where S : unmanaged
        {

        }

        public interface reg64<F,N,S> : reg64<S>, reg<F,W64,S>, ISlotted<N>
            where F : unmanaged, reg64<F,N,S>
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {

        }

        public interface reg64<F,N> : reg64<F,N,Fixed64>
            where F : unmanaged, reg64<F,N>
            where N : unmanaged, ITypeNat
        {

        }

    }
}