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

    public readonly struct WfEventId : IComparable<WfEventId>, IEquatable<WfEventId>, INamed<WfEventId>, ICorrelated<WfEventId>, IChronic<WfEventId>
    {
        [MethodImpl(Inline)]
        public static WfEventId define(string name, CorrelationToken? ct = null, Timestamp? ts = null)
            => new WfEventId(name, ct ?? CorrelationToken.create(), ts ?? now());

        const string Pattern = "{0} | {1} | {2}";        

        /// <summary>
        /// The event data type name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The time at which the event was raised
        /// </summary>
        public Timestamp Ts {get;}

        /// <summary>
        /// Relates the event to other events in the workflow
        /// </summary>
        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public WfEventId(string name, CorrelationToken ct, Timestamp ts)
        {
            Name = name;
            Ct = ct;
            Ts = ts;
        }        

        [MethodImpl(Inline)]
        public bool Equals(WfEventId src)
            => Name == src.Name && Ct == src.Ct && Ts == src.Ts;
        
        [MethodImpl(Inline)]
        public int CompareTo(WfEventId src)
            => Ts.CompareTo(src.Ts);
        
        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Ts, Ct, Name).PadRight(64);       

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