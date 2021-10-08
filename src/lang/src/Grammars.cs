//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Grammars
    {
        const NumericKind Closure = UnsignedInts;

        public static Alphabet<K> alphabet<K>()
            where K : unmanaged, Enum
        {
            var src = Symbols.index<K>().View;
            var count = src.Length;
            var dst = alloc<Symbol<K>>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                seek(dst,i) = new Symbol<K>(s.Key.Value, s.Kind);
            }
            return new Alphabet<K>(dst);
        }
    }
}