//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.Param), StructLayout(LayoutKind.Sequential)]
        public struct ParamRow : ICliRecord<ParamRow>
        {
            public ParameterAttributes Flags;

            public ushort Sequence;

            public StringIndex Name;
        }
    }
}