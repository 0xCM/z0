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
        OpIndex<IdentifiedCode> CreateIndex(IEnumerable<IdentifiedCode> src)
            => index(src);
        
        bool AcceptsParameter(IdentifiedCode src, NumericKind kind)
            => accepts(src, kind);

        IEnumerable<IdentifiedCode> AcceptsParameters(IEnumerable<IdentifiedCode> src, NumericKind k1, NumericKind k2)
            => filter(src, k1, k2);

        IEnumerable<IdentifiedCode> AcceptsParameter(IEnumerable<IdentifiedCode> src, NumericKind kind)
            => filter(src,kind);
        
        int ParameterCount(IdentifiedCode src)
            => arity(src);
                    
        IEnumerable<IdentifiedCode> WithParameterCount(IEnumerable<IdentifiedCode> src, int count)
            => withArity(src, count);
    }
}