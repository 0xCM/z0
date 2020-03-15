//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using NK = NumericKind;

    /// <summary>
    /// Joins numeric types and kinds
    /// </summary>
    public readonly struct NumericTypeKind : IClrTypeModel<NumericTypeKind>, IIdentity<NumericTypeKind>
    {        
        public static NumericTypeKind Empty => new NumericTypeKind(typeof(void), NumericKind.None);

        /// <summary>
        /// Returns numeric type associated with a specified clr type, or the empty
        /// numeric type if no association exists
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static NumericTypeKind From(Type src)
            => Numeric.kind(src).MapValueOrDefault(k => new NumericTypeKind(src,k),NumericTypeKind.Empty);
        
        /// <summary>
        /// Returns numeric type associated with a specified numeric kind, or the empty
        /// numeric type if no association exists
        /// </summary>
        /// <param name="src">The source kind</param>
        public static Option<NumericTypeKind> From(NumericKind src)
        {
            var t = src switch {
                NK.U8 => typeof(byte),
                NK.I8 => typeof(sbyte),
                NK.U16 => typeof(ushort),
                NK.I16 => typeof(short),
                NK.U32 => typeof(uint),
                NK.I32 => typeof(int),
                NK.I64 => typeof(long),
                NK.U64 => typeof(ulong),
                NK.F32 => typeof(float),
                NK.F64 => typeof(double),
                _ => typeof(void)
            };
            return t.IsSome() ? some(new NumericTypeKind(t,src)) : none<NumericTypeKind>();
        }

        [MethodImpl(Inline)]
        public static implicit operator NumericKind(NumericTypeKind src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Type(NumericTypeKind src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static implicit operator string(NumericTypeKind src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(NumericTypeKind a, NumericTypeKind b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(NumericTypeKind a, NumericTypeKind b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        NumericTypeKind(Type t, NumericKind k)
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
        public bool Equals(NumericTypeKind src)
             => IdentityShare.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(NumericTypeKind other)
            => IdentityShare.compare(this, other);

        public override string ToString()
            => Identifier;

        public override int GetHashCode()
            => Subject.GetHashCode();
        
        public override bool Equals(object other)
            => Subject.Equals(other);
    }    
}