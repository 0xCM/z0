//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    partial class AsmSpecs
    {
        /// <summary>
        /// Characterizes an F-Bound polymorphic and index-parametric 64-bit general-purpose register reification
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="N">The index type</typeparam>
        public interface regG64<F,N> : regG<F,N,W64,Fixed64>
            where F : struct, regG64<F,N>
            where N : unmanaged, ITypeNat
        {            
            RegisterKind reg.Kind  => RegisterKind.GP | RegisterKind.W64;
        }
    }
}