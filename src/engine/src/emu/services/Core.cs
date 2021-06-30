//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class Core
    {
        public uint CoreId {get;}

        public Core(uint id)
        {
            CoreId  = id;
        }
    }
}