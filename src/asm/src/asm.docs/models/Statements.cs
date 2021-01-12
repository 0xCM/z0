//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct Statements
        {
            readonly Index<Statement> Data;

            [MethodImpl(Inline)]
            public Statements(Statement[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator Statements(Statement[] src)
                => new Statements(src);
        }

    }
}