//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        /// <summary>
        /// Characterizes a vectorized register reification parametric in index, width and state
        /// </summary>
        /// <typeparam name="F">The reifying type</typeparam>
        /// <typeparam name="W">The register width</typeparam>
        public interface regV<F,N,W,S> : reg<F,N,W,S>
            where F : struct, reg<F,N,W,S>
            where W : unmanaged, IDataWidth
            where S : unmanaged, IFixed
            where N : unmanaged, ITypeNat
        {
            RegisterKind reg.Kind => RegisterKind.Vector;
        }
    }
}