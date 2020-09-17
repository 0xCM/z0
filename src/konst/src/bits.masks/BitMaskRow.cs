//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    using NBK = NumericBaseKind;

    [StructLayout(LayoutKind.Sequential), Table(TableName)]
    public struct BitMaskRow
    {
        public const string TableName = "root.bitmasks";

        public string Name;

        public TypeCode TypeCode;

        public object Data;

        public string Text;

        public NBK Base;
    }
}