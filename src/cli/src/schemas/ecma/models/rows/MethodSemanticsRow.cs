//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct MethodSemanticsRow
    {
        public RowKey Key;

        public MethodSemanticsAttributes Semantic;

        public RowKey Method;

        public RowKey Association;
    }
}