// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        public interface zmm : reg<W512>
        {
            const uint Width = 512;

            RegisterKind reg.Kind => RegisterKind.Zmm;
        }

        public interface zmm<F,N,S> : zmm, reg<F,W512,S>, ISlotted<N> 
            where F : struct, zmm<F,N,S>
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {
        }

        /// <summary>
        /// Characterizes 128-bit vectorized register reifications of parametric index
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="N">The index type</typeparam>
        public interface zmm<F,N> : zmm<F,N,Fixed512>
            where F : struct, zmm<F,N>
            where N : unmanaged, ITypeNat
        {
            
        }
    }
}