//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct AsmFxKind<K> : IAsmFxKind<K>
        where K : unmanaged, Enum
    {
        public AsmFxKind(K literal)
        {
            Literal = literal;
        }

        public K Literal {get;}
    }
}