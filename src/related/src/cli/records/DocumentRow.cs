//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.Document), StructLayout(LayoutKind.Sequential)]
        public struct DocumentRow : ICliRecord<DocumentRow>
        {
            public CliRowKey<Document> Key;

            public BlobIndex Name;

            public GuidIndex HashAlgorithm;

            public BlobIndex Hash;

            public GuidIndex Language;
        }
    }
}