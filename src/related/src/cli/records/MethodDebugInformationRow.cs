//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodDebugInformationRow : ICliRecord<MethodDebugInformationRow,MethodDebugInformation>
        {
            public CliRowKey<MethodDebugInformation> Key;

            public int Document;

            public BlobIndex SequencePoints;
        }
    }
}