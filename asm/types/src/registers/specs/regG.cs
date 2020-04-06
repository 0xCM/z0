//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        /// <summary>
        /// Characterize an F-bound polymorphic regigister reification that is parametric in index, width and state
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="W">The width type</typeparam>
        /// <typeparam name="S">The data type</typeparam>
        /// <typeparam name="N">The index type</typeparam>
        public interface regG<F,N,W,S> : reg<F,N,W,S>
            where F : struct, regG<F,N,W,S>
            where N : unmanaged, ITypeNat
            where W : unmanaged, IDataWidth
            where S : unmanaged, IFixed
       {
            RegisterKind reg.Kind => RegisterKind.GP;
       }   
    }
}