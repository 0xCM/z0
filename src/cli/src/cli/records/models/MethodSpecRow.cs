//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.MethodSpec), StructLayout(LayoutKind.Sequential)]
        public struct MethodSpecRow : ICliRecord<MethodSpecRow>
        {
            public CliRowKey Method;

            public CliBlobIndex Instantiation;
        }
    }
}