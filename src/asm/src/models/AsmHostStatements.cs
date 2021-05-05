//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRecords;

    public readonly struct AsmHostStatements
    {
        public ApiHostUri Host {get;}

        public Index<AsmApiStatement> ApiStatements {get;}

        [MethodImpl(Inline)]
        public AsmHostStatements(ApiHostUri host, Index<AsmApiStatement> statements)
        {
            Host = host;
            ApiStatements = statements;
        }
    }
}