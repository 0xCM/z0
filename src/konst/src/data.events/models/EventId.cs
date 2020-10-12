//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    /// <summary>
    /// Defines logical event identity
    /// </summary>
    public readonly struct EventId
    {
        readonly Vector256<ulong> Data;

        [MethodImpl(Inline)]
        public static EventId define(string eventName, [Caller] string actorName = null, CorrelationToken? ct = null, Timestamp? ts = null)
        {
            var data = vparts(w256, (ulong)address(eventName ?? EmptyString),
                (ulong)address(actorName ?? EmptyString), ct ?? correlate(), ts == null ? timestamp() : ts.Value);
            return new EventId(data);
        }

        [MethodImpl(Inline)]
        internal EventId(Vector256<ulong> data)
            => Data = data;

        public MemoryAddress EventName
        {
            [MethodImpl(Inline)]
            get => vcell(Data, 0);
        }

        public MemoryAddress ActorName
        {
            [MethodImpl(Inline)]
            get => vcell(Data, 1);
        }

        /// <summary>
        /// The originating part/host
        /// </summary>
        public readonly Timestamp Ts
        {
            [MethodImpl(Inline)]
            get => new Timestamp(vcell(Data,2));
        }

        /// <summary>
        /// The event classifier/discriminator
        /// </summary>
        public readonly CorrelationToken Ct
        {
            [MethodImpl(Inline)]
            get => new CorrelationToken(vcell(Data,3));
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} | {1} | {2} | {3}", EventName, ActorName, Ts, Ct);
    }
}