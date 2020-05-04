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

    using static Seed;

    public readonly struct UriBitsQuery : IUriBitsQuery
    {
        public static IUriBitsQuery Service => default(UriBitsQuery);
    }

    public interface IUriBitsQuery
    {
        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        OpIndex<UriBits> CreateIndex(IEnumerable<UriBits> src)
            => Identify.index(src.Select(x => (x.Uri.OpId, x)));
        
        bool AcceptsParameter(UriBits src, NumericKind kind)
            => Identify.numeric(src.Id.TextComponents.Skip(1)).Contains(kind);

        IEnumerable<UriBits> AcceptsParameters(IEnumerable<UriBits> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = Identify.numeric(code.Uri.OpId.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        IEnumerable<UriBits> AcceptsParameter(IEnumerable<UriBits> src, NumericKind kind)
            => from code in src
                where AcceptsParameter(code, kind)
                select code;

        [MethodImpl(Inline)]
        int ParameterCount(UriBits src)
            => src.Uri.OpId.TextComponents.Count() - 1;
                    
        IEnumerable<UriBits> WithParameterCount(IEnumerable<UriBits> src, int count)
            => from code in src
                where ParameterCount(code) == count
                select code;        

    }
}