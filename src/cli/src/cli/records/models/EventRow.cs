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
        [CliRecord(CliTableKind.Event), StructLayout(LayoutKind.Sequential)]
        public struct EventRow : ICliRecord<EventRow>
        {
            public ushort EventFlags;

            public StringIndex Name;

            public CliRowKey EventType;
        }
    }
}