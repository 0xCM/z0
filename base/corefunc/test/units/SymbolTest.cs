//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class SymbolTest : UnitTest<SymbolTest>
    {
        public void MultiCharSymbols()
        {
            Claim.eq(2, BlackBoard.A.Length);
        }

        void Utf8()
        {
            foreach(var point in Utf8AsciPoint.All)
                Trace(point.Format());

        }

    }
}