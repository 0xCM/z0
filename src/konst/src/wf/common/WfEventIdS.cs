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

    public readonly struct WfEventId<E> : IWfEventId<WfEventId<E>>
        where E : struct, IWfEvent<E>
    {
        public string Identifier {get;}

        public Type EventType {get;}

        public Timestamp Ts {get;}

        public CorrelationToken Ct {get;}

        public WfStepId StepId {get;}

        [MethodImpl(Inline)]
        public static implicit operator WfEventId(WfEventId<E> src)
            => new WfEventId(src.Identifier, src.Ct, src.Ts);

        [MethodImpl(Inline)]
        public WfEventId(WfStepId step, CorrelationToken ct, Timestamp? ts = null)
        {
            EventType = typeof(E);
            Ts = ts ?? timestamp();
            Ct = ct;
            StepId = step;
            Identifier = text.format("{0} | {1} | {2} | {3}", Ts, Ct, EventType.Name, step);
        }

        [MethodImpl(Inline)]
        public WfEventId(WfFunc fx, CorrelationToken ct, Timestamp? ts = null)
        {
            EventType = typeof(E);
            Ts = ts ?? timestamp();
            Ct = ct;
            StepId = fx.StepId;
            Identifier = text.format("{0} | {1} | {2} | {3}", Ts, Ct, fx.StepId.Name, fx.Name.Format());
        }

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => Ts.Hashed;
        }

         [MethodImpl(Inline)]
         public int CompareTo(WfEventId<E> src)
            => Ts.CompareTo(src.Ts);

        [MethodImpl(Inline)]
        public bool Equals(WfEventId<E> src)
            => Identifier == src.Identifier;

        [MethodImpl(Inline)]
        public string Format()
            => Identifier.PadRight(56);

        public override int GetHashCode()
            => (int)Hashed;

        public override bool Equals(object src)
            => src is WfEventId<E> x && Equals(x);

        public override string ToString()
            => Format();
    }
}