//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static memory;

    partial struct ClrQuery
    {
        [Op]
        public static Span<FieldInfo> literals(in IndexedSeq<FieldInfo> src, Span<FieldInfo> dst)
        {
            var k = 0u;
            var view = src.Terms;
            var count = view.Length;
            for(var i=0u; i<count; i++)
                if(skip(view,i).IsLiteral)
                    seek(dst, k++) = skip(view,i);
            return slice(dst,k);
        }

        [Op]
        public static Span<FieldInfo> literals(Type src, Span<FieldInfo> dst)
            => literals(fields(src), dst);
    }
}