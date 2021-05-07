//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldRow : IRecord<FieldRow>
        {
            public CliRowKey Key;

            public FieldAttributes Flags;

            public StringIndex Name;

            public BlobIndex Signature;
        }
    }
}