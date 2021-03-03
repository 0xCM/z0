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
    /// Represents a keyword in the asm grammar
    /// </summary>
    public readonly struct AsmKeyword
    {
        public Name Name {get;}

        [MethodImpl(Inline)]
        public AsmKeyword(Name name)
            => Name = name;
    }
}