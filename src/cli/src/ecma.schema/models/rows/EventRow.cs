//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct EventRow : IRecord<EventRow>
    {
        public RowKey Key;

        public ushort EventFlags;

        public FK<name> Name;

        public int EventType;
    }
}