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
        [StructLayout(LayoutKind.Sequential)]
        public struct DocumentRow : ICliRecord<DocumentRow,Document>
        {
            public CliRowKey<Document> Key;

            public BlobIndex Name;

            public GuidIndex HashAlgorithm;

            public BlobIndex Hash;

            public GuidIndex Language;
        }
    }
}