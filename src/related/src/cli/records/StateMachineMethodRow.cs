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
        [Record(CliTableKind.StateMachineMethod), StructLayout(LayoutKind.Sequential)]
        public struct StateMachineMethodRow : IRecord<StateMachineMethodRow>
        {
            public CliRowKey Key;

            public CliRowKey MoveNextMethod;

            public CliRowKey KickoffMethod;
        }
    }
}