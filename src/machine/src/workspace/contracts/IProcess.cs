//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    public interface IProcess 
    {
        int Id {get;}

        int ExitCode {get;}

        CorrelationToken Transmit(IMessage message);

        int WaitForExit();
    }
}