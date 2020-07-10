//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static Span<FieldInfo> literals(ReadOnlySpan<FieldInfo> src, Span<FieldInfo> dst)
        {
            var k = 0u;            
            var count = src.Length;
            for(var i=0u; i<count; i++)
                if(IsLiteral(skip(src,i)))
                    seek(dst, k++) = skip(src,i);            
            return slice(dst,k);                    
        }

        [MethodImpl(Inline), Op]
        public static Span<FieldInfo> literals(Type src, Span<FieldInfo> dst)
            => literals(Reflex.fields(src), dst);    
    }
}