//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    partial class AsmSpecs
    {

        /// <summary>
        /// Characterizes an F-Bound polymorphic and index-parametric 8-bit general-purpose register reification
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="N">The index type</typeparam>
        public interface regG8<F,N> : regG<F,N,W8,Fixed8>
            where F : struct, regG8<F,N>
            where N : unmanaged, ITypeNat
        {            
            RegisterKind reg.Kind  => RegisterKind.GP | RegisterKind.W8;

        }
    }
}