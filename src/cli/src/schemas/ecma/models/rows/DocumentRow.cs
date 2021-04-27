//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record(CliTableKind.Document), StructLayout(LayoutKind.Sequential)]
    public struct DocumentRow : IRecord<DocumentRow>
    {
        public RowKey Key;

        public BlobIndex Name;

        public GuidIndex HashAlgorithm;

        public BlobIndex Hash;

        public GuidIndex Language;
    }
}