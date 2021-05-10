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
        public struct MemberRefRow : ICliRecord<MemberRefRow>
        {
            public CliRowKey Parent;

            public StringIndex Name;

            public BlobIndex Signature;
        }
    }
}