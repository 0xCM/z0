//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldDefRow : ICliRecord<FieldDefRow>
        {
            public FieldAttributes Attributes;

            public StringIndex Name;

            public BlobIndex Signature;

            public uint Offset;

            public BlobIndex Marshal;
        }
    }
}