//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public struct BitMaskRow
    {
        public string Name;

        public TypeCode TypeCode;

        public object Data;

        public string Text;

        public NumericBaseKind Base;
    }
}