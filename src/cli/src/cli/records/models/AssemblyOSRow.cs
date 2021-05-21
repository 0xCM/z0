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
        [CliRecord(CliTableKind.AssemblyOS), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyOSRow : ICliRecord<AssemblyOSRow>
        {

        }
    }
}