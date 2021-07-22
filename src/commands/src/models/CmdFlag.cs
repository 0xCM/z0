//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CmdFlag
    {
        public ushort Index {get;}

        public bit State {get;}

        [MethodImpl(Inline)]
        public CmdFlag(ushort index, bit state)
        {
            Index = index;
            State = state;
        }
    }
}