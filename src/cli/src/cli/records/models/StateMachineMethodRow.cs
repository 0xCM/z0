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
        [CliRecord(CliTableKind.StateMachineMethod), StructLayout(LayoutKind.Sequential)]
        public struct StateMachineMethodRow : ICliRecord<StateMachineMethodRow>
        {
            public CliRowKey MoveNextMethod;

            public CliRowKey KickoffMethod;
        }
    }
}