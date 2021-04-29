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
        [StructLayout(LayoutKind.Sequential)]
        public struct StateMachineMethodRow : IRecord<StateMachineMethodRow>
        {
            public RowKey Key;

            public RowKey MoveNextMethod;

            public RowKey KickoffMethod;
        }
    }
}