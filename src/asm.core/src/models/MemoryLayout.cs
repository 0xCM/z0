//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum MemoryLayout : byte
    {
        None,

        [Meaning(Notes.FlatMemoryModel)]
        Flat,

        [Meaning(Notes.SegmentedMemoryModel)]
        Segmented,

        [Meaning(Notes.RealMemoryModel)]
        Real
    }
}