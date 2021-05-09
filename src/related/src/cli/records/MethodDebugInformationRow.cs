//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.MethodDebugInformation), StructLayout(LayoutKind.Sequential)]
        public struct MethodDebugInformationRow : ICliRecord<MethodDebugInformationRow>
        {
            public CliRowKey Key;

            public int Document;

            public BlobIndex SequencePoints;
        }
    }
}