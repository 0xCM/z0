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
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct MethodRow : IRecord<MethodRow>
        {
            public RowKey Key;

            public int BodyOffset;

            public MethodImplAttributes ImplFlags;

            public MethodAttributes Flags;

            public StringIndex Name;

            public BlobIndex Signature;

            public int ParamList;
        }
    }
}