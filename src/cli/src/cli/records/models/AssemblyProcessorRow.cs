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
        [CliRecord(CliTableKind.AssemblyProcessor), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyProcessorRow : ICliRecord<AssemblyProcessorRow>
        {

        }
    }
}