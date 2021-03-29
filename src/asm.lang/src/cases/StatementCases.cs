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

        public partial class Statements
        {
            AsmStatementBuilder Builder;

            public static Statements create()
                => new Statements();

            Statements()
            {
                Builder = new AsmStatementBuilder();
            }

        }

    }
}