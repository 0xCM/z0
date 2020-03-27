//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static gmath;    

    /// <summary>
    /// Defines a sequence term
    /// </summary>
    public readonly struct NumericSeqTerm<T> : IEquatable<NumericSeqTerm<T>>
        where T : unmanaged
    {
        /// <summary>
        /// The integer that maps to the term value
        /// </summary>
        public readonly int Index;

        /// <summary>
        /// The term's value
        /// </summary>        
        public readonly T Value;

        public static NumericSeqTerm<T> Empty => default;
                        
        [MethodImpl(Inline)]
        public static implicit operator (int i, T t)(NumericSeqTerm<T> src)
            => (src.Index, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator T(NumericSeqTerm<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator NumericSeqTerm<T>((int i, T t) src)
            => new NumericSeqTerm<T>(src.i, src.t);

        [MethodImpl(Inline)]
        public NumericSeqTerm(int index, T value)
        {
            this.Index = index;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies whether the term is empty
        /// </summary>
        public bool IsEmpty
            => Index == 0 && !gmath.nonz(Value);

        /// <summary>
        /// Renders the term by default as 'a_i = Value' where i denotes the term index
        /// </summary>
        /// <param name="id">The sequence identifier, if specified</param>
        public string Format(char? id = null)
            => IsEmpty ? "{}" : $"{id ?? 'a'}_{Index} = {Value}";
        
        [MethodImpl(Inline)]
        public bool Equals(NumericSeqTerm<T> rhs)
            => Index == rhs.Index && gmath.eq(Value, rhs.Value);
        
        public override bool Equals(object rhs)
            => rhs is NumericSeqTerm<T> t && Equals(t);
        
        public override int GetHashCode()
            => HashCode.Combine(Index,Value);
    }
}