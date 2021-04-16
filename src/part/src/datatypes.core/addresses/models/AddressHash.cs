//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AddressHash : IRecord<AddressHash>
    {
        public const string TableId = "addresses.hashed";

        public MemoryAddress Address;

        public uint Index;

        public uint HashCode;
    }
}