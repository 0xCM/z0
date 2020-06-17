//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UriHexQuery : IUriHexQuery
    {
        public static IUriHexQuery Service => default(UriHexQuery);
    }

    public interface IUriHexQuery
    {
        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        OpIndex<UriHex> CreateIndex(IEnumerable<UriHex> src)
            => Identify.index(src.Select(x => (x.OpUri.OpId, x)));
        
        bool AcceptsParameter(UriHex src, NumericKind kind)
            => Identify.numeric(src.Id.TextComponents.Skip(1)).Contains(kind);

        IEnumerable<UriHex> AcceptsParameters(IEnumerable<UriHex> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = Identify.numeric(code.OpUri.OpId.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        IEnumerable<UriHex> AcceptsParameter(IEnumerable<UriHex> src, NumericKind kind)
            => from code in src
                where AcceptsParameter(code, kind)
                select code;

        [MethodImpl(Inline)]
        int ParameterCount(UriHex src)
            => src.OpUri.OpId.TextComponents.Count() - 1;
                    
        IEnumerable<UriHex> WithParameterCount(IEnumerable<UriHex> src, int count)
            => from code in src
                where ParameterCount(code) == count
                select code;        
    }
}