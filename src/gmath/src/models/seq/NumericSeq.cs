//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Defines a data structure for sparse/partial sequence representation
    /// </summary>
    public readonly ref struct NumericSeq<T>
        where T : unmanaged
    {            
        readonly Span<NumericSeqTerm<T>> terms;

        public static NumericSeq<T> Empty => new NumericSeq<T>(NumericSeqTerm<T>.Empty);

        internal NumericSeq(params T[] terms)
        {
            if(terms.Length != 0)
            {
                this.terms = new NumericSeqTerm<T>[terms.Length];
                for(var i=0; i<terms.Length; i++)
                    this.terms[i] = (i,terms[i]);
            }
            else
                this.terms = Empty.terms;
        }

        [MethodImpl(Inline)]
        internal NumericSeq(params NumericSeqTerm<T>[] terms)
        {
            if(terms.Length != 0)
                this.terms = terms;
            else
                this.terms = Empty.terms;
        }

        internal NumericSeq(Span<T> terms)
        {
            if(terms.Length != 0)
            {
                this.terms = new NumericSeqTerm<T>[terms.Length];
                for(var i=0; i<terms.Length; i++)
                    this.terms[i] = (i,terms[i]);
            }
            else
                this.terms = Empty.terms;
        }

        /// <summary>
        /// The sequence terms
        /// </summary>
        public ReadOnlySpan<NumericSeqTerm<T>> Terms
        {
            [MethodImpl(Inline)]
            get => terms;
        }

        /// <summary>
        /// The number of terms in the sequence
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => terms.Length;
        }

        /// <summary>
        /// Returns a reference to an index-identified term
        /// </summary>
        public ref NumericSeqTerm<T> this[int idx]
        {
            [MethodImpl(Inline)]
            get => ref seek(terms, idx);
        }

        /// <summary>
        /// Returns a reference to the first term of the seqence
        /// </summary>
        public ref NumericSeqTerm<T> First
        {
            [MethodImpl(Inline)]
            get => ref this[0];
        }

        public ref readonly NumericSeqTerm<T> Last
        {
            [MethodImpl(Inline)]
            get => ref this[Length - 1];
        }

        public string Format(char? delimiter = null)
        {
            var fmt = text.build();
            fmt.Append(Chars.LBrace);
            for(var i=0; i<terms.Length; i++)
            {
                fmt.Append(terms[i].Format());
                if(i != terms.Length - 1)
                {
                    fmt.Append(delimiter ?? Chars.Comma);
                    fmt.Append(Chars.Space);
                }                
            }
            fmt.Append(Chars.RBrace);
            return fmt.ToString();
        }        
    }
}