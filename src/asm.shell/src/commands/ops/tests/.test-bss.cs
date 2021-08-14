//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".test-bss")]
        Outcome TestBss(CmdArgs args)
        {
            var result = Outcome.Success;
            var dispenser = BssSections.dispenser();
            var entries = dispenser.Entries();
            var count = entries.Length;
            const sbyte Pad = -16;

            Write(RP.attrib(nameof(dispenser.EntryCount), count));
            for(ushort i=0; i<count; i++)
            {
                //ref readonly var entry = ref skip(entries,i);
                ref readonly var entry = ref dispenser.Entry(i);
                var desc = entry.Descriptor();
                var capacity = desc.Capacity;
                Write(RP.PageBreak32);
                Write(RP.attrib(Pad, nameof(desc.Index), desc.Index));
                Write(RP.attrib(Pad, nameof(desc.BaseAddress), desc.BaseAddress));
                Write(RP.attrib(Pad, nameof(desc.EndAddress), desc.EndAddress));
                Write(RP.attrib(Pad, nameof(capacity.Indicator), capacity.Indicator));
                Write(RP.attrib(Pad, nameof(capacity.CellSize), capacity.CellSize));
                Write(RP.attrib(Pad, nameof(capacity.CellsPerSeg), capacity.CellsPerSeg));
                Write(RP.attrib(Pad, nameof(capacity.SegSize), capacity.SegSize));
                Write(RP.attrib(Pad, nameof(capacity.SegCount), capacity.SegCount));
                Write(RP.attrib(Pad, nameof(capacity.SegsPerBlock), capacity.SegsPerBlock));
                Write(RP.attrib(Pad, nameof(capacity.BlockCount), capacity.BlockCount));
                Write(RP.attrib(Pad, nameof(capacity.BlockSize), capacity.BlockSize));
                Write(RP.attrib(Pad, nameof(capacity.TotalSize), capacity.TotalSize));
            }

            return result;
       }
    }
}