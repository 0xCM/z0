//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public sealed partial class AsmGen : WfService<AsmGen,AsmGen>
    {

        public string StatementFactories(Index<AsmSpecInfo> src)
        {
            return EmptyString;
        }



    }


}