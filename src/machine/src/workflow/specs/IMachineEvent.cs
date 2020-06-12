//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;

    public interface IMachineEvent : IAppEvent
    {

    }
    
    public interface IMachineEvent<F> : IMachineEvent, IAppEvent<F>
        where F : struct, IMachineEvent<F>
    {
        AppMsgColor IAppEvent.Flair => AppMsgColor.Magenta;

        F Define(ReadOnlySpan<byte> data) => new F();
    }
}