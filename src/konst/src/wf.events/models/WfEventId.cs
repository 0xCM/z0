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
        public string Identifier {get;}

        public Timestamp Ts {get;}

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        WfEventId(Type type)
        {
            Ts = timestamp();
            Ct = CorrelationToken.Empty;;
            Identifier = text.format("{0} | {1} | {2}Row", Ts, Ct, type.Name);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = correlate(0ul);
            Identifier = text.format("{0} | {1} | {2}", Ts, Ct, name);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2}", Ts, Ct, name);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, string label, WfStepId step, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2} | {3} | {4}", Ts, Ct, name, label, step);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, string label, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2} | {3}", Ts, Ct, name, label);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, CmdId cmd, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2} | {3}", Ts, Ct, name, cmd);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, WfStepId step, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2} | {3}", Ts, Ct, name, step);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, WfStepId step, EventLevel level, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Ct = ct;
            Identifier = text.format("{0} | {1} | {2} | {3} | {4}", Ts, Ct, level, name, step);
        }

        [MethodImpl(Inline)]
        WfEventId(Type type, WfStepId step, CorrelationToken ct, Timestamp? ts = null)
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

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((Type type, WfStepId step, CorrelationToken ct) src)
            => new WfEventId(src.type, src.step, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((string name, WfStepId step, CorrelationToken ct) src)
            => new WfEventId(src.name, src.step, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((string name, WfStepId step, EventLevel level, CorrelationToken ct) src)
            => new WfEventId(src.name, src.step, src.level, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((string name, CorrelationToken ct) src)
            => new WfEventId(src.name, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId(string name)
            => new WfEventId(name);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((string name, string label, WfStepId step, CorrelationToken ct) src)
            => new WfEventId(src.name, src.label, src.step, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((string name, string label, CorrelationToken ct) src)
            => new WfEventId(src.name, src.label, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((string name, CmdId cmd, CorrelationToken ct) src)
            => new WfEventId(src.name, src.cmd, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId(Type row)
            => new WfEventId(row);
    }
}