//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.MethodDebugInformation), StructLayout(LayoutKind.Sequential)]
        public struct MethodDebugInformationRow : ICliRecord<MethodDebugInformationRow>
        {
            public int Document;

            public BlobIndex SequencePoints;
        }
    }
}