//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public unsafe abstract class CpuState<G,V>
        where G : unmanaged
        where V : unmanaged
    {
        protected G* GpRegs;

        protected V* VRegs;

        protected CpuState()
        {

        }
    }

}