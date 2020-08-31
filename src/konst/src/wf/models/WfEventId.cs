//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct WfEventId : IWfEventId<WfEventId>
    {
        /// <summary>
        /// Creates a workflow event
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">The correlation token, if any</param>
        /// <param name="ts">The timestamp which, if unspecified, will default to the event creation time (now)</param>
        [MethodImpl(Inline)]
        public static WfEventId define(string name, CorrelationToken? ct = null)
            => new WfEventId(name, ct ?? correlate(0ul));

        [MethodImpl(Inline)]
        public static WfEventId define(Type type, WfStepId step, CorrelationToken ct)
            => new WfEventId(type,step,ct,now());

        [MethodImpl(Inline)]
        public static WfEventId define<T>(WfStepId step, CorrelationToken ct)
            where T : struct, IWfEvent<T>
                => new WfEventId(typeof(T), step, ct, now());

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((Type type, WfStepId step, CorrelationToken ct) src)
            => new WfEventId(src.type, src.step, src.ct, now());

        readonly string Identifier;

        public Timestamp Ts {get;}

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public WfEventId(string name, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2}", Ts, Ct, name);
        }

        [MethodImpl(Inline)]
        public WfEventId(Type type, WfStepId step, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2} | {3}", Ts, Ct, type.Name, step);
        }

        /// <summary>
        /// The event data type name
        /// </summary>
        public string Name
            => Identifier;

        [MethodImpl(Inline)]
        public bool Equals(WfEventId src)
            => Identifier == src.Identifier;

        [MethodImpl(Inline)]
        public int CompareTo(WfEventId src)
            => Ts.CompareTo(src.Ts);

        [MethodImpl(Inline)]
        public string Format()
            => Identifier.PadRight(56);

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => Ts.Hashed;
        }

        public override int GetHashCode()
            => (int)Hashed;


        public override bool Equals(object src)
            => src is WfEventId i && Equals(i);

        public override string ToString()
            => Format();
    }
}