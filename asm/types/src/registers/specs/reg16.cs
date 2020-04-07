//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {

        public interface reg16 : reg<W16>
        {
            const uint Width = 16;
        }

        public interface reg16<S> : reg16, reg<W16,S>
            where S : unmanaged
        {

        }


        public interface reg16<F,N,S> : reg16<S>,reg<F,W16,S>, ISlotted<N>
            where F : unmanaged, reg16<F,N,S>
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {

        }

        public interface reg16<F,N> : reg16<F,N,Fixed16>
            where F : unmanaged, reg16<F,N>
            where N : unmanaged, ITypeNat
        {

        }
    }
}