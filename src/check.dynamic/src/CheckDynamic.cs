//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;
    using static z;
    using static BufferSeqId;

    using K = Kinds;

    public readonly struct CheckDynamic : TCheckDynamic
    {
        public static TCheckDynamic Checker => default(CheckDynamic);
    }
}