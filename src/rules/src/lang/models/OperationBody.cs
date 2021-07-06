//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using Z0.Lang;

    partial struct Rules
    {
        public readonly struct OperationBody
        {
            public IScope Scope {get;}

            public Index<Statement> Definition {get;}

            [MethodImpl(Inline)]
            public OperationBody(IScope scope, Index<Statement> statements)
            {
                Scope = scope;
                Definition = statements;
            }
        }
    }
}