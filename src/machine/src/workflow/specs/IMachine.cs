//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    public interface IMachine : IServiceAllocation<IMachineContext>, IMachineEventClient
    {
        void Run();
    }
}