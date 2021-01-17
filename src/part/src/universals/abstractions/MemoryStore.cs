//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class MemoryStore<H,T>
        where H : MemoryStore<H,T>
        where T : struct
    {
        [FixedAddressValueType]
        protected static T Data;
    }
}