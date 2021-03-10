//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents the target of an invocation
    /// </summary>
    public struct AsmCallee
    {
        /// <summary>
        /// The target's base address
        /// </summary>
        public MemoryAddress Base {get;}

        /// <summary>
        /// The target's identifier
        /// </summary>
        public AsmSymbol Identity {get;}

        [MethodImpl(Inline)]
        public AsmCallee(MemoryAddress @base, AsmSymbol identity)
        {
            Identity = identity;
            Base = @base;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}