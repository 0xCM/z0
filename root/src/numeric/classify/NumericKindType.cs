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

    public readonly struct NumericKindType<T> : INumericKindType<T> 
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public static implicit operator NumericKind(NumericKindType<T> src)
            => Numeric.kind<T>();
    }
    
    /// <summary>
    /// Joins numeric types and kinds
    /// </summary>
    public readonly struct NumericKindType : INumericKindType
    {        
        public static NumericKindType Empty => new NumericKindType(typeof(void), NumericKind.None);

        /// <summary>
        /// Returns numeric type associated with a specified clr type, or the empty
        /// numeric type if no association exists
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static NumericKindType From(Type src)
            => Numeric.kind(src).MapValueOrDefault(k => new NumericKindType(src,k),NumericKindType.Empty);
        
        /// <summary>
        /// Returns numeric type associated with a specified numeric kind, or the empty
        /// numeric type if no association exists
        /// </summary>
        /// <param name="src">The source kind</param>
        public static Option<NumericKindType> From(NumericKind src)
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
            return t.IsSome() ? some(new NumericKindType(t,src)) : none<NumericKindType>();
        }

        [MethodImpl(Inline)]
        public static implicit operator NumericKind(NumericKindType src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Type(NumericKindType src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static implicit operator string(NumericKindType src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(NumericKindType a, NumericKindType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(NumericKindType a, NumericKindType b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        NumericKindType(Type t, NumericKind k)
        {
            this.Subject = t;
            this.Kind = k;
            this.Identifier = k.Format();
        }

        public Type Subject {get;}

        public string Identifier {get;}

        public readonly NumericKind Kind;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Subject == typeof(void);
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out Type clrtype, out NumericKind kind)
        {
            clrtype = Subject;
            kind = Kind;                
        }

        [MethodImpl(Inline)]
        public bool Equals(NumericKindType src)
             => IdentityShare.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(NumericKindType other)
            => IdentityShare.compare(this, other);

        public override string ToString()
            => Identifier;

        public override int GetHashCode()
            => Subject.GetHashCode();
        
        public override bool Equals(object other)
            => Subject.Equals(other);
    }    
}