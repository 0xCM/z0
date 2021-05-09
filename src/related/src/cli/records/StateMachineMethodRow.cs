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
        [StructLayout(LayoutKind.Sequential)]
        public struct StateMachineMethodRow : ICliRecord<StateMachineMethodRow,StateMachineMethod>
        {
            public CliRowKey<StateMachineMethod> Key;

            public CliRowKey MoveNextMethod;

            public CliRowKey KickoffMethod;
        }
    }
}