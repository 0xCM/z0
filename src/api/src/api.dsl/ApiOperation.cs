//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiOperation
    {
        public Identifier Name {get;}

        public ulong Kind {get;}

        public Index<ApiOperand> Operands {get;}
    }
}