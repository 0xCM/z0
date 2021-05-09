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
        [Record(CliTableKind.MethodDebugInformation), StructLayout(LayoutKind.Sequential)]
        public struct MethodDebugInformationRow : ICliRecord<MethodDebugInformationRow>
        {
            public CliRowKey<MethodDebugInformation> Key;

            public int Document;

            public BlobIndex SequencePoints;
        }
    }
}