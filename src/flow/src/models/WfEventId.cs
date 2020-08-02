//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    [ApiDataType]
    public readonly struct WfEventId : IComparable<WfEventId>, IEquatable<WfEventId>, INamed<WfEventId>, ICorrelated<WfEventId>, IChronic<WfEventId>
    {
        [MethodImpl(Inline)]
        public static WfEventId define(string name, CorrelationToken? ct = null, Timestamp? ts = null)
            => new WfEventId(name, ct ?? CorrelationToken.create(), ts ?? now());

        const string Pattern = "[{0}:{1}/{2}]";        

        /// <summary>
        /// The event data type name
        /// </summary>
        public readonly StringRef Name;

        /// <summary>
        /// The time at which the event was raised
        /// </summary>
        public readonly Timestamp Timestamp;

        /// <summary>
        /// Relates the event to other events in the workflow
        /// </summary>
        public readonly CorrelationToken Correlation;

        [MethodImpl(Inline)]
        public WfEventId(string name, CorrelationToken ct, Timestamp ts)
        {
            Name = name;
            Correlation = ct;
            Timestamp = ts;
        }        

        [MethodImpl(Inline)]
        public bool Equals(WfEventId src)
            => Name.Address == src.Name.Address && Correlation == src.Correlation && Timestamp == src.Timestamp;
        
        [MethodImpl(Inline)]
        public int CompareTo(WfEventId src)
            => Timestamp.CompareTo(src.Timestamp);
        
        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Timestamp, Correlation, Name.Format()).PadRight(64);       

        public uint Hashed
        {        
            [MethodImpl(Inline)]
            get => Timestamp.Hashed;
        }

        [MethodImpl(Inline), Ignore]
        int IComparable<WfEventId>.CompareTo(WfEventId src)
            => CompareTo(src);


        [MethodImpl(Inline), Ignore]
        bool IEquatable<WfEventId>.Equals(WfEventId src)
            => Equals(src);
        
        [MethodImpl(Inline), Ignore]
        string ITextual.Format()
            => Format();

        StringRef INamed.Name   
            => Name;

        Timestamp IChronic.Timestamp
            => Timestamp;

        CorrelationToken ICorrelated.Correlation
            => Correlation;
        
        [MethodImpl(Inline), Ignore]
        public override int GetHashCode()
            => (int)Hashed;

        [MethodImpl(Inline), Ignore]
        
        public override bool Equals(object src)
            => src is WfEventId i && Equals(i);

        [MethodImpl(Inline), Ignore]
        public override string ToString()
            => Format();
    }
}