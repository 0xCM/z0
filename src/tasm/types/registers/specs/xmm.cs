// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        public interface xmm : reg<W128>
        {
            const uint Width = 128;

            RegisterKind reg.Kind => RegisterKind.Xmm;
        }

        public interface xmm<S> : xmm, reg<W128,S>
            where S : unmanaged
        {            
        
        }

        public interface xmm<F,N,S> : xmm<S>, reg<F,W128,S>, ISlotted<N> 
            where F : struct, xmm<F,N,S>
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a 128-bit vectorized register reification of parametric index
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="N">The index type</typeparam>
        public interface xmm<F,N> : xmm<F,N,Fixed128> 
            where F : struct, xmm<F,N>
            where N : unmanaged, ITypeNat
        {

        }
    }
}