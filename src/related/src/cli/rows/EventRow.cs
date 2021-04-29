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
        [Record(CliTableKind.Event), StructLayout(LayoutKind.Sequential)]
        public struct EventRow : IRecord<EventRow>
        {
            public RowKey Key;

            public ushort EventFlags;

            public StringIndex Name;

            public RowKey EventType;
        }
    }
}