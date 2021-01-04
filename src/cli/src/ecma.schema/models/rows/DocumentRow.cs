//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct DocumentRow
    {
        public RowKey Key;

        public FK<bytes> Name;

        public FK<guid> HashAlgorithm;

        public FK<bytes> Hash;

        public FK<guid> Language;
    }
}