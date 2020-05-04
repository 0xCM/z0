//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static IdentityShare;
    
    /// <summary>
    /// Correlates a value with a key that uniquely identifies the value within some context
    /// </summary>
    public readonly struct CorrelationToken : IIdentifiedType<CorrelationToken>
    {
        public static CorrelationToken Empty => new CorrelationToken(string.Empty);

        /// <summary>
        /// The key that identifies the value
        /// </summary>
        public string IdentityText {get;}

        [MethodImpl(Inline)]
        public static CorrelationToken From(string value)
            => new CorrelationToken(value);

        [MethodImpl(Inline)]
        public static CorrelationToken From<T>(T value)
            => new CorrelationToken(value.ToString());

        [MethodImpl(Inline)]
        public static CorrelationToken New()
            => new CorrelationToken(Guid.NewGuid().ToString());

        [MethodImpl(Inline)]
        public static bool operator==(CorrelationToken a, CorrelationToken b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(CorrelationToken a, CorrelationToken b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        CorrelationToken(string value)
        {
            this.IdentityText = value;
        }

        public bool IsEmpty => string.IsNullOrWhiteSpace(IdentityText);
         
        [MethodImpl(Inline)]
        public bool Equals(CorrelationToken src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(CorrelationToken other)
            => compare(this, other);        

        public override string ToString()
            => IdentityText;
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);
    }
}