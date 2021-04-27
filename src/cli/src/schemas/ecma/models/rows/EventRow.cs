//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct EventRow : IRecord<EventRow>
    {
        public RowKey Key;

        public ushort EventFlags;

        public StringIndex Name;

        public RowKey EventType;
    }
}