//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ImageTables
    {
        [Table]
        public struct OptionalHeaderS
        {
            public ulong SizeOfStackReserve;

            public ulong SizeOfStackCommit;

            public ulong SizeOfHeapReserve;

            public ulong SizeOfHeapCommit;

            public uint LoaderFlags;

            public uint NumberOfRvaAndSizes;
        }
    }
}