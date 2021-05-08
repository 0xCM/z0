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
        [Record(CliTableKind.Document), StructLayout(LayoutKind.Sequential)]
        public struct DocumentRow : IRecord<DocumentRow>
        {
            public CliRowKey Key;

            public BlobIndex Name;

            public GuidIndex HashAlgorithm;

            public BlobIndex Hash;

            public GuidIndex Language;
        }
    }
}