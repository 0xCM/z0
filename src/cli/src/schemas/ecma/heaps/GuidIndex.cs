//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using static HeapIndexKinds;

    public readonly struct GuidIndex : IHeapIndex<GuidIndexKind,GuidIndex>
    {
        public uint Key {get;}
    }
}