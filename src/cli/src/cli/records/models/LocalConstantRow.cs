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
        [CliRecord(CliTableKind.LocalConstant), StructLayout(LayoutKind.Sequential)]
        public struct LocalConstantRow : ICliRecord<LocalConstantRow>
        {
            public StringIndex Name;

            public CliBlobIndex Signature;
        }
    }
}