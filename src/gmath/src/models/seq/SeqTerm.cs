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

    /// <summary>
    /// Defines a sequence term
    /// </summary>
    public readonly struct SeqTerm<T>
    {
        /// <summary>
        /// The integer that maps to the term value
        /// </summary>
        public readonly uint Index;

        /// <summary>
        /// The term's value
        /// </summary>
        public readonly T Value;

        public static SeqTerm<T> Empty => default;

        [MethodImpl(Inline)]
        public static implicit operator (uint i, T t)(SeqTerm<T> src)
            => (src.Index, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator T(SeqTerm<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator SeqTerm<T>((uint i, T t) src)
            => new SeqTerm<T>(src.i, src.t);

        [MethodImpl(Inline)]
        public SeqTerm(uint index, T value)
        {
            Index = index;
            Value = value;
        }

        /// <summary>
        /// Specifies whether the term is empty
        /// </summary>
        public bool IsEmpty
            => Value == null ||  (Index == 0 && Value.Equals(default));

        /// <summary>
        /// Renders the term by default as 'a_i = Value' where i denotes the term index
        /// </summary>
        /// <param name="name">The sequence identifier, if specified</param>
        public string Format(char? name = null)
            => IsEmpty ? "{}" : $"{name ?? 'a'}_{Index} = {Value}";
    }
}