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
    /// Captures operation invocation information from the client perspective
    /// </summary>
    public struct AsmCallInfo : ITextual
    {
        /// <summary>
        /// The base-relative address that captures the offset follows the client call instruction
        /// </summary>
        public AsmCallSite CallSite;

        /// <summary>
        /// The argument supplied to the call instruction
        /// </summary>
        public AsmCallee Target;

        [MethodImpl(Inline)]
        public AsmCallInfo(AsmCallSite callsite, AsmCallee target)
        {
            CallSite = callsite;
            Target = target;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}