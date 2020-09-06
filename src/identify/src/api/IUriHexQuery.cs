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
        OpIndex<ApiHex> CreateIndex(IEnumerable<ApiHex> src)
            => index(src);

        bool AcceptsParameter(ApiHex src, NumericKind kind)
            => accepts(src, kind);

        IEnumerable<ApiHex> AcceptsParameters(IEnumerable<ApiHex> src, NumericKind k1, NumericKind k2)
            => filter(src, k1, k2);

        IEnumerable<ApiHex> AcceptsParameter(IEnumerable<ApiHex> src, NumericKind kind)
            => filter(src,kind);

        int ParameterCount(ApiHex src)
            => arity(src);

        IEnumerable<ApiHex> WithParameterCount(IEnumerable<ApiHex> src, int count)
            => withArity(src, count);
    }
}