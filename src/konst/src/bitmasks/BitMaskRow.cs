//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct BitMaskRow
    {
        public const string TableId = "bitmasks";

        public const byte FieldCount = 5;

        public string Name;

        public TypeCode TypeCode;

        public object Data;

        public string Text;

        public NumericBaseKind Base;
    }
}