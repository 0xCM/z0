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
        [CliRecord(CliTableKind.EventMap), StructLayout(LayoutKind.Sequential)]
        public struct EventMapRow : ICliRecord<EventMapRow>
        {
            public CliRowKey Parent;

            public CliRowKey EventList;
        }
    }
}