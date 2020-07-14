//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    public interface IMessagePacket
    {
        Guid CorrelationToken { get; }

        object Payload { get; }

        string Label { get; }
    }

    public interface IMessagePacket<out P> : IMessagePacket
    {
        new P Payload { get; }
    }
}