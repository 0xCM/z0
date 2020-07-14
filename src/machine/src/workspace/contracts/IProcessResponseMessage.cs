//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    public interface IProcessResponseMessge : IMessage
    {
        IProcessCommand Command { get; }

        IProcessResponseMessge Response { get; }

    }

    public interface IProcessResponseMessage<P> : IProcessResponseMessge
        where P : IProcessCommand
    {
        new P Command { get; }
    }

    public interface IProcessResponseMessage<R,P> : IProcessResponseMessage<P>
        where P : IProcessCommand
        where R : IProcessResponseMessge
    {
        new P Command { get; }

        new R Response { get; }
    }
}