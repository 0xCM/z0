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
        [Record(CliTableKind.EventMap), StructLayout(LayoutKind.Sequential)]
        public struct EventMapRow : IRecord<EventMapRow>
        {
            public CliRowKey Key;

            public CliRowKey Parent;

            public CliRowKey EventList;
        }
    }
}