//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IMachineEvent<F> : IAppEvent<F>
        where F : struct, IMachineEvent<F>
    {
        AppMsgColor IAppEvent.Flair => AppMsgColor.Magenta;
    }
}