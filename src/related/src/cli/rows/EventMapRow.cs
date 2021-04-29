//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct EventMapRow : IRecord<EventMapRow>
        {
            public RowKey Key;

            public RowKey Parent;

            public RowKey EventList;
        }
    }
}