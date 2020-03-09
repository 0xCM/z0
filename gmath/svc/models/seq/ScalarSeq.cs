//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;    

    /// <summary>
    /// Defines a data structure for sparse/partial sequence representation
    /// </summary>
    public readonly ref struct ScalarSeq<T>
        where T : unmanaged
    {            
        readonly Span<ScalarSeqTerm<T>> terms;

        public static ScalarSeq<T> Empty => new ScalarSeq<T>(ScalarSeqTerm<T>.Empty);

        internal ScalarSeq(params T[] terms)
        {
            if(terms.Length != 0)
            {
                this.terms = new ScalarSeqTerm<T>[terms.Length];
                for(var i=0; i<terms.Length; i++)
                    this.terms[i] = (i,terms[i]);
            }
            else
                this.terms = Empty.terms;
        }

        [MethodImpl(Inline)]
        internal ScalarSeq(params ScalarSeqTerm<T>[] terms)
        {
            if(terms.Length != 0)
                this.terms = terms;
            else
                this.terms = Empty.terms;
        }

        internal ScalarSeq(Span<T> terms)
        {
            if(terms.Length != 0)
            {
                this.terms = new ScalarSeqTerm<T>[terms.Length];
                for(var i=0; i<terms.Length; i++)
                    this.terms[i] = (i,terms[i]);
            }
            else
                this.terms = Empty.terms;
        }

        /// <summary>
        /// The sequence terms
        /// </summary>
        public ReadOnlySpan<ScalarSeqTerm<T>> Terms
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
        public ref ScalarSeqTerm<T> this[int idx]
        {
            [MethodImpl(Inline)]
            get => ref seek(terms, idx);
        }

        /// <summary>
        /// Returns a reference to the first term of the seqence
        /// </summary>
        public ref ScalarSeqTerm<T> First
        {
            [MethodImpl(Inline)]
            get => ref this[0];
        }

        public ref readonly ScalarSeqTerm<T> Last
        {
            [MethodImpl(Inline)]
            get => ref this[Length - 1];
        }

        public string Format(char? delimiter = null)
        {
            var fmt = text.factory.Builder();
            fmt.Append(AsciSym.LBrace);
            for(var i=0; i<terms.Length; i++)
            {
                fmt.Append(terms[i].Format());
                if(i != terms.Length - 1)
                {
                    fmt.Append(delimiter ?? AsciSym.Comma);
                    fmt.Append(AsciSym.Space);
                }                
            }
            fmt.Append(AsciSym.RBrace);
            return fmt.ToString();
        }        
    }
}