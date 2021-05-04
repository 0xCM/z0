//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ImageRecords;

    public readonly struct Images
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