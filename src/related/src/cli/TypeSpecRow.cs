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
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeSpecRow : IRecord<TypeSpecRow>
        {
            public CliRowKey Key;

            public BlobIndex Signature;
        }
    }
}