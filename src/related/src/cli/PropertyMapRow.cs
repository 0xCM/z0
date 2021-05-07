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
        public struct PropertyMapRow : IRecord<PropertyMapRow>
        {
            public CliRowKey Key;

            public CliRowKey Parent;

            public CliRowKey PropertyList;
        }
    }
}