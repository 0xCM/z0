//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Relations;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct MethodRow : IRecord<MethodRow>
    {
        public RowKey Key;

        public int BodyOffset;

        public MethodImplAttributes ImplFlags;

        public MethodAttributes Flags;

        public FK<StringIndex> Name;

        public FK<BlobIndex> Signature;

        public int ParamList;
    }
}