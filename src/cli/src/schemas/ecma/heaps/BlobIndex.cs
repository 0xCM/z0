//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    using static HeapIndexKinds;

    public readonly struct BlobIndex : IHeapIndex<BlobIndexKind,BlobIndex>
    {
        public uint Value {get;}
    }
}