//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct StateMachineMethodRow : IRecord<StateMachineMethodRow>
    {
        public RowKey Key;

        public RowKey MoveNextMethod;

        public RowKey KickoffMethod;
    }
}