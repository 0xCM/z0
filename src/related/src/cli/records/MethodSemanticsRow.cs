//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodSemanticsRow : ICliRecord<MethodSemanticsRow,MethodSemantics>
        {
            public CliRowKey<MethodSemantics> Key;

            public MethodSemanticsAttributes Semantic;

            public CliRowKey Method;

            public CliRowKey Association;
        }
    }
}