//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static UriHexQuery;

    public interface IUriHexQuery
    {
        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        OpIndex<X86UriHex> CreateIndex(IEnumerable<X86UriHex> src)
            => index(src);

        bool AcceptsParameter(X86UriHex src, NumericKind kind)
            => accepts(src, kind);

        IEnumerable<X86UriHex> AcceptsParameters(IEnumerable<X86UriHex> src, NumericKind k1, NumericKind k2)
            => filter(src, k1, k2);

        IEnumerable<X86UriHex> AcceptsParameter(IEnumerable<X86UriHex> src, NumericKind kind)
            => filter(src,kind);

        int ParameterCount(X86UriHex src)
            => arity(src);

        IEnumerable<X86UriHex> WithParameterCount(IEnumerable<X86UriHex> src, int count)
            => withArity(src, count);
    }
}