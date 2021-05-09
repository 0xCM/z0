//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct EventRow : ICliRecord<EventRow,Event>
        {
            public CliRowKey<Event> Key;

            public ushort EventFlags;

            public StringIndex Name;

            public CliRowKey EventType;
        }
    }
}