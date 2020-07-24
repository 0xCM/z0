//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Structures;
    
    using static z;
    
    [ApiDataType]
    public readonly struct CorrelationToken<T> : IDataType<CorrelationToken<T>>
        where T : unmanaged
    {
        public readonly T Value;

        [MethodImpl(Inline)]
        public CorrelationToken(T value)
            => Value = value;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(Value);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => empty(Value);
        }
    
        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => nonempty(Value);
        }

        [MethodImpl(Inline)]
        public static bool operator==(CorrelationToken<T> a, CorrelationToken<T> b)
            => eq(a.Value,b.Value);

        [MethodImpl(Inline)]
        public static bool operator!=(CorrelationToken<T> a, CorrelationToken<T> b)
            => neq(a.Value,b.Value);

        [MethodImpl(Inline)]
        public static implicit operator T(CorrelationToken<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public bool Equals(in CorrelationToken<T> src)
            => eq(Value, src.Value);

        [MethodImpl(Inline)]
        public string Format()
            => format(Value);

        uint IHashed.Hash
        {
            [Ignore]
            get => Hash;
        }

        bool INullity.IsEmpty
        {
            [Ignore]
            get => IsEmpty;
        }
    
        bool INullity.IsNonEmpty
        {
            [Ignore]
            get => IsNonEmpty;
        }

        [Ignore]
        bool IEquatable<CorrelationToken<T>>.Equals(CorrelationToken<T> src) 
            => Equals(src);
        
        [Ignore]
        string ITextual.Format()
            => Format();

        [Ignore]
        public override bool Equals(object src)
            => src is CorrelationToken<T> x && Equals(x);
        
        [Ignore]
        public override int GetHashCode()
            => (int) Hash;

        [Ignore]
        public override string ToString()
            => Format();
    }
}