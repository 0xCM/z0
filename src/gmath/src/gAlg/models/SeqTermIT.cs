//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a sequence term
    /// </summary>
    public readonly struct SeqTerm<I,T>
        where I : unmanaged
    {
        /// <summary>
        /// The sequence index
        /// </summary>
        public I Index {get;}

        /// <summary>
        /// The term value
        /// </summary>
        public T Value {get;}

        [MethodImpl(Inline)]
        public SeqTerm(I index, T value)
        {
            Index = index;
            Value = value;
        }

        public string Format()
            => string.Format("{0}: {1}", Index, Value);

        public override string ToString()
            => Format();


        /// <summary>
        /// Specifies whether the term is empty
        /// </summary>
        public bool IsEmpty
            => Value == null ||  (Index.Equals(default) && Value.Equals(default));

        public static SeqTerm<I,T> Empty => default;

        [MethodImpl(Inline)]
        public static implicit operator (I i, T t)(SeqTerm<I,T> src)
            => (src.Index, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator T(SeqTerm<I,T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator SeqTerm<I,T>((I i, T t) src)
            => new SeqTerm<I,T>(src.i, src.t);
    }
}