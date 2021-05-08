//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRecords
    {
        [Record(CliTableKind.MethodSemantics), StructLayout(LayoutKind.Sequential)]
        public struct MethodSemanticsRow : IRecord<MethodSemanticsRow>
        {
            public CliRowKey Key;

            public MethodSemanticsAttributes Semantic;

            public CliRowKey Method;

            public CliRowKey Association;
        }
    }
}