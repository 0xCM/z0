//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents a reference to a register
    /// </summary>
    public readonly struct AsmRegRef
    {
        public RegName RegName {get;}

        public RegRefKind RefKind {get;}

        [MethodImpl(Inline)]
        public AsmRegRef(RegName reg, RegRefKind kind)
        {
            RegName = reg;
            RefKind = kind;
        }
    }
}