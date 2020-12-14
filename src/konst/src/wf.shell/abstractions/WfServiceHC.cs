//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [WfService]
    public abstract class WfService<H,C> : WfService<H>, IWfService<H,C>
        where H : WfService<H,C>, new()
    {

        public override Type ContractType => typeof(C);
    }
}