//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    //using NK = NumericKind;
    using static NumericKind;

    /// <summary>
    /// Represents the parametrically-identified numeric kind
    /// </summary>
    public readonly struct NK<T> : INumericKind<T> 
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator NumericKind(NK<T> src)
            => NumericIdentity.kind<T>();

        [MethodImpl(Inline)]
        public static implicit operator T(NK<T> src)
            => default;
    }
    
    /// <summary>
    /// Joins numeric types and kinds
    /// </summary>
    public readonly struct NumericKinded : INumericKind
    {                
        public Type Subject {get;}

        public string Identifier {get;}

        public NumericKind Class {get;}

        public static NumericKinded Empty => new NumericKinded(typeof(void), NumericKind.None);

        [MethodImpl(Inline)]
        public static NK<T> From<T>(T t = default)
            where T : unmanaged
                => default(NK<T>);

        /// <summary>
        /// Returns numeric type associated with a specified clr type, or the empty numeric type if no association exists
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static NumericKinded From(Type src)
            => NumericIdentity.kind(src).MapValueOrDefault(k => new NumericKinded(src,k), NumericKinded.Empty);
        
        /// <summary>
        /// Returns numeric type associated with a specified numeric kind, or the empty
        /// numeric type if no association exists
        /// </summary>
        /// <param name="src">The source kind</param>
        public static Option<NumericKinded> From(NumericKind src)
        {
            var t = src switch {
                U8 => typeof(byte),
                I8 => typeof(sbyte),
                U16 => typeof(ushort),
                I16 => typeof(short),
                U32 => typeof(uint),
                I32 => typeof(int),
                I64 => typeof(long),
                U64 => typeof(ulong),
                F32 => typeof(float),
                F64 => typeof(double),
                _ => typeof(void)
            };
            return t.IsSome() ? some(new NumericKinded(t,src)) : none<NumericKinded>();
        }

        [MethodImpl(Inline)]
        public static implicit operator NumericKind(NumericKinded src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator Type(NumericKinded src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static implicit operator string(NumericKinded src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(NumericKinded a, NumericKinded b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(NumericKinded a, NumericKinded b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        NumericKinded(Type t, NumericKind k)
        {
            this.Subject = t;
            this.Class = k;
            this.Identifier = k.Format();
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Subject == typeof(void);
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out Type clrtype, out NumericKind kind)
        {
            clrtype = Subject;
            kind = Class;                
        }

        [MethodImpl(Inline)]
        public bool Equals(NumericKinded src)
             => IdentityShare.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(NumericKinded other)
            => IdentityShare.compare(this, other);

        public override string ToString()
            => Identifier;

        public override int GetHashCode()
            => Subject.GetHashCode();
        
        public override bool Equals(object other)
            => Subject.Equals(other);
    }    
}