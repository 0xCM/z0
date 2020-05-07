//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        public interface reg8 : reg<W8>
        {
            const uint Width = 8;
        }

        public interface reg8<S> : reg8, reg<W8,S>
            where S : unmanaged
        {            
        
        }

        public interface reg8<F,N,S> : reg8<S>, reg<F,W8,S>, ISlotted<N>
            where F : unmanaged, reg8<F,N,S>
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {
            
        }

        public interface reg8<F,N> : reg8<F,N,Fixed8>
            where F : unmanaged, reg8<F,N>
            where N : unmanaged, ITypeNat
        {

        }
    }
}