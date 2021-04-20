//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using static Relations;

    [StructLayout(LayoutKind.Sequential)]
    public struct StateMachineMethodRow : IRecord<StateMachineMethodRow>
    {
        public RowKey Key;

        public Token MoveNextMethod;

        public Token KickoffMethod;
    }
}