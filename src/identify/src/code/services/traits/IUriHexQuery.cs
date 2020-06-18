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
        OpIndex<UriHex> CreateIndex(IEnumerable<UriHex> src)
            => index(src);
        
        bool AcceptsParameter(UriHex src, NumericKind kind)
            => accepts(src, kind);

        IEnumerable<UriHex> AcceptsParameters(IEnumerable<UriHex> src, NumericKind k1, NumericKind k2)
            => filter(src, k1, k2);

        IEnumerable<UriHex> AcceptsParameter(IEnumerable<UriHex> src, NumericKind kind)
            => filter(src,kind);
        
        int ParameterCount(UriHex src)
            => arity(src);
                    
        IEnumerable<UriHex> WithParameterCount(IEnumerable<UriHex> src, int count)
            => withArity(src, count);
    }
}