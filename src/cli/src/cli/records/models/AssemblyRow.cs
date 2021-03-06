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
        [CliRecord(CliTableKind.Assembly), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRow : ICliRecord<AssemblyRow>
        {
            public AssemblyHashAlgorithm HashAlgorithm;

            public AssemblyVersion Version;

            public AssemblyFlags Flags;

            public CliBlobIndex PublicKey;

            public CliStringIndex Name;

            public CliStringIndex Culture;
        }
    }
}