//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct Images
    {
        [Record(CliTableKind.MethodDef), StructLayout(LayoutKind.Sequential)]
        public struct MethodDefRow : IRecord<MethodDefRow>
        {
            public RowKey Key;

            public uint BodyOffset;

            public MethodImplAttributes ImplFlags;

            public MethodAttributes Flags;

            public StringIndex Name;

            public BlobIndex Signature;

            public RowKey ParamList;
        }
    }
}