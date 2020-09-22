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

    using api = ApiIdentity;

    public readonly struct ApiHexQuery
    {
        public static ApiHexQuery Service => default;

        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        public OpIndex<ApiHex> CreateIndex(IEnumerable<ApiHex> src)
            => api.index(src);

        public bool AcceptsParameter(ApiHex src, NumericKind kind)
            => accepts(src, kind);

        public IEnumerable<ApiHex> WithParameterCount(IEnumerable<ApiHex> src, int count)
            => withArity(src, count);

        /// <summary>
        /// Determines whether an operation accepts an argument of specified numeric kind
        /// </summary>
        /// <param name="src">The encoded operation</param>
        /// <param name="match">The kind to match</param>
        public static bool accepts(ApiHex src, NumericKind match)
            => api.numeric(src.Id.TextComponents.Skip(1)).Contains(match);

        /// <summary>
        /// Determines the arity of the encoded operation
        /// </summary>
        /// <param name="src">The encoded operation</param>
        [MethodImpl(Inline)]
        public static int arity(ApiHex src)
            => src.OpUri.OpId.TextComponents.Count() - 1;

        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        public static OpIndex<ApiHex> index(IEnumerable<ApiHex> src)
            => api.index(src);

        /// <summary>
        /// Excludes source operations that do not accept two parameters of specified numeric kind
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="k1">The first parameter kind</param>
        /// <param name="k2">The second parameter kind</param>
        public static IEnumerable<ApiHex> accepts(IEnumerable<ApiHex> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = api.numeric(code.OpUri.OpId.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        public static IEnumerable<ApiHex> accepts(IEnumerable<ApiHex> src, NumericKind kind)
            => from code in src
                where accepts(code, kind)
                select code;

        public static IEnumerable<ApiHex> withArity(IEnumerable<ApiHex> src, int count)
            => from code in src
                where arity(code) == count
                select code;
    }
}