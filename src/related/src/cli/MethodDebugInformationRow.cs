//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct MethodDebugInformationRow : IRecord<MethodDebugInformationRow>
        {
            public CliRowKey Key;

            public int Document;

            public BlobIndex SequencePoints;
        }
    }
}