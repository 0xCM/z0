//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    [SymSource]
    public enum PrimalKind
    {
        None,

        [Symbol("u")]
        UnsignedInt,

        [Symbol("i")]
        SignedInt,

        [Symbol("f")]
        Float
    }
}