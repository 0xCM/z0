//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class CpuCore
    {
        public uint CoreId {get;}

        public CpuCore(uint id)
        {
            CoreId  = id;
        }
    }
}