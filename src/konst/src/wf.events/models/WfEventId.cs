//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct WfEventId : IWfEventId<WfEventId>
    {
        [MethodImpl(Inline)]
        public static WfEventId define(string name, WfStepId step, EventLevel level)
            => new WfEventId(name, step, level, CorrelationToken.Default);

        [MethodImpl(Inline)]
        public static WfEventId define(string name, WfStepId step)
            => new WfEventId(name, step, CorrelationToken.Default);

        public string Identifier {get;}

        public Timestamp Ts {get;}

        const string PatternBase = "{0} | {1,-18}";

        [MethodImpl(Inline)]
        WfEventId(Type type)
        {
            Ts = timestamp();
            Identifier = text.format(PatternBase, Ts, type.Name);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase, Ts, name);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase, Ts, name);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, string label, WfStepId step, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase + " | {2} | {3}", Ts, name, label, step);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, string label, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase + " | {2}", Ts, name, label);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, CmdId cmd, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase + " | {2}", Ts, name, cmd);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, WfStepId step, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase + " | {2}", Ts, name, step);
        }

        [MethodImpl(Inline)]
        WfEventId(string name, WfStepId step, EventLevel level, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase + " | {2} | {3}", Ts, name, level, step);
        }

        [MethodImpl(Inline)]
        WfEventId(EventKind kind, WfStepId step, EventLevel level, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase + " | {2} | {3}", Ts, kind, level, step);
        }

        [MethodImpl(Inline)]
        WfEventId(Type type, WfStepId step, CorrelationToken ct, Timestamp? ts = null)
        {
            Ts = ts ?? timestamp();
            Identifier = text.format(PatternBase + " | {2}", Ts, type.Name, step);
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
            get => alg.hash.combine(Ts.Hashed, alg.hash.calc(Name));
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
        public static implicit operator WfEventId((EventKind kind, WfStepId step, CorrelationToken ct) src)
            => new WfEventId(src.kind.ToString(), src.step, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((EventKind kind, CmdId cmd, CorrelationToken ct) src)
            => new WfEventId(src.kind.ToString(), src.cmd, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((string name, WfStepId step, EventLevel level, CorrelationToken ct) src)
            => new WfEventId(src.name, src.step, src.level, src.ct);

        [MethodImpl(Inline)]
        public static implicit operator WfEventId((EventKind kind, WfStepId step, EventLevel level, CorrelationToken ct) src)
            => new WfEventId(src.kind, src.step, src.level, src.ct);

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