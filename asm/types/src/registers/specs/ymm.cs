// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        /// <summary>
        /// Characterizes 128-bit vectorized register reifications of parametric index
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="N">The index type</typeparam>
        public interface ymm<F,N> :  regV<F,N,W256,Fixed256V> 
            where F : struct, ymm<F,N>
            where N : unmanaged, ITypeNat
        {
            RegisterKind reg.Kind => RegisterKind.Ymm;
        }
    }
}