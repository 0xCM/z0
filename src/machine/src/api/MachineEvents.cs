//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost]
    public partial class MachineEvents : IApiHost<MachineEvents>
    {
        public static IMachineEvents Factory => MachineEventFactory.Service;
    }
}