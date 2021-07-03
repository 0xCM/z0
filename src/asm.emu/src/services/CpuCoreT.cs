//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class CpuCore<T> : CpuCore
        where T : unmanaged
    {
        public CpuCore(uint id)
            : base(id)
        {

        }
    }
}