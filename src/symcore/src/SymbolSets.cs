//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;
    using static Root;

    public readonly struct SymbolSets
    {
        public static SymSet from(Type src)
        {
            var tokens = Tokens.specs(src);
            var count = tokens.Length;
            var type = Enums.@base(src);
            var dst = new SymSet((uint)count);
            var attrib = src.Tag<SymSourceAttribute>();
            dst.Name = src.Name;
            dst.DataType = type;
            dst.Flags = src.Tag<FlagsAttribute>().IsSome();
            dst.SymbolKind = src.Tag<SymSourceAttribute>().MapValueOrElse(x => x.SymKind, () => EmptyString);
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref skip(tokens,i);
                dst.Symbols[i] = token.Expr;
                dst.Names[i] = token.Name;
                dst.Values[i] = token.Value;
                dst.Descriptions[i] = token.Description;
            }

            return dst;
        }
    }
}