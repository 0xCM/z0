//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class Core<T> : Core
        where T : unmanaged
    {
        public Core(uint id)
            : base(id)
        {

        }
    }
}