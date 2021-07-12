//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class ApiExtractor
    {
        AddressBank LogSegments(uint step)
        {
            var bank = ImageMemory.bank(Wf, LogRegions(step));
            EmitRows(bank.Segments, Db.Table<ProcessSegment>(SegDir, step.ToString()));
            return bank;
        }

        AddressBank LogSegments(uint step, ReadOnlySpan<ProcessMemoryRegion> regions)
        {
            var bank = ImageMemory.bank(Wf, regions);
            EmitRows(bank.Segments, Db.Table<ProcessSegment>(SegDir, step.ToString()));
            return bank;
        }
    }
}