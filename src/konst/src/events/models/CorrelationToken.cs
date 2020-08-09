//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Correlates a value with a key that uniquely identifies the value within some context
    /// </summary>
    public readonly struct CorrelationToken : ITextual, IComparable<CorrelationToken>, IEquatable<CorrelationToken>
    {
        public readonly ulong Value;

        [MethodImpl(Inline)]
        public static CorrelationToken define(ulong value)
            => new CorrelationToken(value);

        [MethodImpl(Inline)]
        public static CorrelationToken define(PartId part)
            => new CorrelationToken((ulong)part);

        [MethodImpl(Inline)]
        public static CorrelationToken create()
            => new CorrelationToken((ulong)z.now().Ticks);

        [MethodImpl(Inline)]
        public static implicit operator ulong (CorrelationToken src)
            => src.Value;

        [MethodImpl(Inline)]
        public static bool operator==(CorrelationToken a, CorrelationToken b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(CorrelationToken a, CorrelationToken b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public CorrelationToken(ulong value)
            => Value = value;
        
        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }
         
        [MethodImpl(Inline)]
        public bool Equals(CorrelationToken src)
            => Value == src.Value;
       
        [MethodImpl(Inline)]
        public int CompareTo(CorrelationToken other)
            => Value.CompareTo(other.Value);

        public override string ToString()
            => Value.ToString();
 
        public override int GetHashCode()
            => (int)z.hash(Value);

        public override bool Equals(object src)
            => src is CorrelationToken t && Equals(t);

        public string Format()
            => Value.ToString();
        
        public static CorrelationToken Empty 
            => default;
    }
}