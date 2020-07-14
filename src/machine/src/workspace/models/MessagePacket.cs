//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MessagePacket<K> : IMessagePacket<K>
    {
        public MessagePacket(Guid CorrelationToken, K Payload, string Label = null)
        {
            this.CorrelationToken = CorrelationToken;
            this.Payload = Payload;
            this.Label = Label ?? string.Empty;
        }

        public Guid CorrelationToken { get; }

        public K Payload { get; }

        public string Label { get; }

        object IMessagePacket.Payload
            => Payload;

        public override string ToString()
            => Payload?.ToString() ?? string.Empty;
    }

    public struct MessagePacket : IMessagePacket<string>
    {
        public MessagePacket(Guid CorrelationToken, string Payload, string Label = null)
        {
            this.CorrelationToken = CorrelationToken;
            this.Payload = Payload ?? string.Empty;
            this.Label = Label ?? string.Empty;
        }

        public Guid CorrelationToken { get; }

        public string Payload { get; }

        public string Label { get; }

        object IMessagePacket.Payload
            => Payload;

        public override string ToString()
            => Payload.ToString();
    }
}