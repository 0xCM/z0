//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct DocumentRow : ICliRecord<DocumentRow>
        {
            public BlobIndex Name;

            public GuidIndex HashAlgorithm;

            public BlobIndex Hash;

            public GuidIndex Language;
        }
    }
}