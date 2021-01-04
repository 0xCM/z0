//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct MethodRow : IRecord<MethodRow>
    {
        public RowKey Key;

        public int BodyOffset;

        public ushort ImplFlags;

        public ushort Flags;

        public FK<name> Name;

        public FK<sig> Signature;

        public int ParamList;
    }
}