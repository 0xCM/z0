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
        public struct FieldRow : ICliRecord<FieldRow>
        {
            public FieldAttributes Flags;

            public StringIndex Name;

            public BlobIndex Signature;
        }
    }
}