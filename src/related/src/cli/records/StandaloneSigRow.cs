//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.StandAloneSig), StructLayout(LayoutKind.Sequential)]
        public struct StandaloneSigRow  : IRecord<StandaloneSigRow>
        {
            public CliRowKey Key;

            public BlobIndex Signature;
        }
    }
}