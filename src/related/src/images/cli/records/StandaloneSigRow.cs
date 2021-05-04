//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct StandaloneSigRow  : IRecord<StandaloneSigRow>
        {
            public RowKey Key;

            public BlobIndex Signature;
        }
    }
}