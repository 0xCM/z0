//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    public abstract class WfService<H,S> : WfService<H>
        where H : WfService<H,S>, new()
        where S : struct
    {
        protected WfService()
        {

        }

        [FixedAddressValueType]
        protected static S State;
    }
}