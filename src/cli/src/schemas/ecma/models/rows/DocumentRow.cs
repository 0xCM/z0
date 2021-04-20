//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using static Relations;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct DocumentRow : IRecord<DocumentRow>
    {
        public RowKey Key;

        public FK<BlobIndex> Name;

        public FK<GuidIndex> HashAlgorithm;

        public FK<BlobIndex> Hash;

        public FK<GuidIndex> Language;
    }
}