// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        public interface ymm : reg<W256>
        {
            const uint Width = 256;

            RegisterKind reg.Kind => RegisterKind.Ymm;
        }

        public interface ymm<S> : ymm, reg<W256,S>
            where S : unmanaged
        {            
        
        }

        public interface ymm<F,N,S> : ymm<S>,reg<F,W256,S>,  ISlotted<N> 
            where F : struct, ymm<F,N,S>
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {

        }

        /// <summary>
        /// Characterizes 128-bit vectorized register reifications of parametric index
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="N">The index type</typeparam>
        public interface ymm<F,N> : ymm<F,N,Fixed256V>
            where F : struct, ymm<F,N>
            where N : unmanaged, ITypeNat
        {
            
        }
    }
}