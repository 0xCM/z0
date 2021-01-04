//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct CustomDebugInformationRow : IRecord<CustomDebugInformationRow>
    {
        public RowKey Key;

        public token Parent;

        public FK<Guid> Kind;

        public FK<bytes> Value;
    }
}