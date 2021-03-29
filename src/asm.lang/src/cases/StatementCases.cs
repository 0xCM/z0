//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class AsmCases
    {
        [ApiHost("cases.statements")]
        public partial struct Statements
        {
            AsmStatementBuilder Builder;

            public static Statements create()
                => new Statements(new AsmStatementBuilder());

            [MethodImpl(Inline)]
            Statements(AsmStatementBuilder builder)
            {
                Builder = builder;
            }
        }
    }
}