//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    [RecordSet]
    public readonly partial struct PeRecords : IRecordSet<PeRecords>
    {
        [MethodImpl(Inline), Op]
        public static DirectoryEntryRow directory(Address32 rva, uint size)
        {
            var dst = new DirectoryEntryRow();
            dst.Rva = rva;
            dst.Size = size;
            return dst;
        }
    }
}