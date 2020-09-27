//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ResourceDirectoryEntry
    {
        public int NameOrId;

        public int DataOffset;

        public bool IsDirectory
        {
            get  => (this.DataOffset & 0x80000000) == 0x80000000;
        }

        public int OffsetToDirectory
        {
            get => DataOffset & 0x7FFFFFFF;

        }
        public int OffsetToData
        {
            get => DataOffset & 0x7FFFFFFF;
        }
    }
}