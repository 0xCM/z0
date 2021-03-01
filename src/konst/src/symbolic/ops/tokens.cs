//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;
    using static Part;

    partial struct Symbolic
    {
        public static Index<Token<E>> tokens<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var details = Enums.details<E,T>().View;
            var count = details.Length;
            var buffer = alloc<Token<E>>(count);
            ref var dst = ref first(buffer);
            for(uint i=1; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var symbol = detail.Field.Tag<SymbolAttribute>().MapValueOrDefault(a => a.Symbol, EmptyString);
                seek(dst,i) = Tokens.token(i, detail.Name, detail.LiteralValue, symbol);
            }
            return buffer;
        }
    }
}