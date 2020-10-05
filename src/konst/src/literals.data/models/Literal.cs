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
    /// Covers a value that can be interpreted as a compile-time literal constant
    /// </summary>
    public readonly struct Literal<T>
    {
        public readonly StringRef Declarer;
        
        public readonly StringRef Name;

        public readonly uint Index;

        public readonly T Value;

        public readonly LiteralKind Kind;
        
        public readonly bool Refinement;
        
        [MethodImpl(Inline)]
        public Literal(string declarer, string name, uint index, T data, LiteralKind kind, bool refinement)
        {
            Declarer = declarer;
            Name = name;
            Index = index;
            Value = data;
            Kind = kind;
            Refinement = refinement;            
        }

        [MethodImpl(Inline)]
        public bool Equals(Literal<T> src)
            => object.Equals(Value,src.Value);
        
        [MethodImpl(Inline)]
        public string Format()
            => Value?.ToString() ?? string.Empty;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value?.GetHashCode() ?? 0;
        
        public override bool Equals(object src)
            => src is Literal<T> v && Equals(v);

        public static Literal<T> Empty 
            => default;
    }
}