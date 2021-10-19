//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;
    using static Root;

    partial struct Symbols
    {
        public static SymSet set(Type src)
        {
            var specs = Symbols.syminfo(src);
            var count = specs.Length;
            var type = Enums.@base(src);
            var dst = new SymSet((uint)count);
            var attrib = src.Tag<SymSourceAttribute>();
            dst.Name = src.Name;
            dst.DataType = type;
            dst.Flags = src.Tag<FlagsAttribute>().IsSome();
            dst.SymbolKind = src.Tag<SymSourceAttribute>().MapValueOrElse(x => x.SymKind, () => EmptyString);
            for(var i=0; i<count; i++)
            {
                ref readonly var sec = ref skip(specs,i);
                dst.Symbols[i] = sec.Expr;
                dst.Names[i] = sec.Name;
                dst.Values[i] = sec.Value;
                dst.Descriptions[i] = sec.Description;
            }

            return dst;
        }
    }
}