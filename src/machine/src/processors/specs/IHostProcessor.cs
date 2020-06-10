//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    using Z0.Asm;

    public enum HostHandlerKind : byte
    {
        A = 0,

        B = 1,

        C = 2
    }

    public interface IHostProcessor : IAsmProcessor<HostHandlerKind,HostInstructions>
    {

    }
}