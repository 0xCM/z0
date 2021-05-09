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
        [Record(CliTableKind.StateMachineMethod), StructLayout(LayoutKind.Sequential)]
        public struct StateMachineMethodRow : ICliRecord<StateMachineMethodRow>
        {
            public CliRowKey<StateMachineMethod> Key;

            public CliRowKey MoveNextMethod;

            public CliRowKey KickoffMethod;
        }
    }
}