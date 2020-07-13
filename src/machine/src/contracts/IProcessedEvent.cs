//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IProcessedEvent<F> : IAppEvent<F>
        where F : struct, IProcessedEvent<F>
    {
        AppMsgColor IAppEvent.Flair 
            => AppMsgColor.Magenta;

        F Define(ReadOnlySpan<byte> data) 
            => new F();
    }
}