//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    using static HeapIndexKinds;

    public readonly struct SystemStringIndex : IHeapIndex<SystemStringIndexKind,SystemStringIndex>
    {
        public uint Value {get;}
    }
}