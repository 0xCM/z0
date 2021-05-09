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
        [Record(CliTableKind.EventMap), StructLayout(LayoutKind.Sequential)]
        public struct EventMapRow : ICliRecord<EventMapRow>
        {
            public CliRowKey<EventMap> Key;

            public CliRowKey Parent;

            public CliRowKey EventList;
        }
    }
}