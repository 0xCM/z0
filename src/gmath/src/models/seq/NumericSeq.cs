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
    /// Defines a data structure for sparse/partial sequence representation
    /// </summary>
    public readonly ref struct NumericSeq<T>
        where T : unmanaged
    {
        readonly Span<SeqTerm<T>> Terms;

        internal NumericSeq(params T[] src)
        {
            var input = @readonly(src);
            if(src.Length != 0)
            {
                this.Terms = new SeqTerm<T>[src.Length];
                for(var i=0u; i<src.Length; i++)
                    seek(this.Terms,i) = new SeqTerm<T>(i, skip(input,i));
            }
            else
                Terms = Empty.Terms;
        }

        [MethodImpl(Inline)]
        internal NumericSeq(params SeqTerm<T>[] src)
        {
            if(src.Length != 0)
                Terms = src;
            else
                Terms = Empty.Terms;
        }

        internal NumericSeq(Span<T> src)
        {
            if(src.Length != 0)
            {
                this.Terms = new SeqTerm<T>[src.Length];
                for(var i=0u; i<src.Length; i++)
                    seek(this.Terms,i) = new SeqTerm<T>(i, skip(src,i));
            }
            else
                Terms = Empty.Terms;
        }

        public ReadOnlySpan<SeqTerm<T>> TermView
        {
            [MethodImpl(Inline)]
            get => Terms;
        }

        public Span<SeqTerm<T>> TermEdit
        {
            [MethodImpl(Inline)]
            get => Terms;
        }

        /// <summary>
        /// The number of terms in the sequence
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Terms.Length;
        }

        /// <summary>
        /// Returns a reference to an index-identified term
        /// </summary>
        public ref SeqTerm<T> this[int idx]
        {
            [MethodImpl(Inline)]
            get => ref seek(Terms, (uint)idx);
        }

        /// <summary>
        /// Returns a reference to the first term of the sequence
        /// </summary>
        public ref SeqTerm<T> First
        {
            [MethodImpl(Inline)]
            get => ref this[0];
        }

        public ref SeqTerm<T> Last
        {
            [MethodImpl(Inline)]
            get => ref this[Length - 1];
        }

        public string Format(char delimiter)
        {
            var fmt = text.build();
            fmt.Append(Chars.LBrace);
            for(var i=0; i<Terms.Length; i++)
            {
                fmt.Append(Terms[i].Format());
                if(i != Terms.Length - 1)
                {
                    fmt.Append(delimiter);
                    fmt.Append(Chars.Space);
                }
            }
            fmt.Append(Chars.RBrace);
            return fmt.ToString();
        }

        public static NumericSeq<T> Empty => new NumericSeq<T>(SeqTerm<T>.Empty);
    }
}