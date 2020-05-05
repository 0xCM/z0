//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    public interface IMachine : IServiceAllocation<IMachineContext>, IMachineClient<IMachineBroker>
    {
        void Run();
    }
}