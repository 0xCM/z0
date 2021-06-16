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
        [CliRecord(CliTableKind.TypeSpec), StructLayout(LayoutKind.Sequential)]
        public struct TypeSpecRow : ICliRecord<TypeSpecRow>
        {
            public CliBlobIndex Signature;
        }
    }
}