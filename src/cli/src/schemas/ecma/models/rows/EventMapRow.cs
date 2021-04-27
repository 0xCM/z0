//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct EventMapRow : IRecord<EventMapRow>
    {
        public RowKey Key;

        public RowKey Parent;

        public RowKey EventList;
    }
}