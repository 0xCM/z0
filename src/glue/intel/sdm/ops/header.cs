//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        [Op]
        public static TableHeader header(TableKind kind, string[] labels)
        {
            var count = labels.Length;
            var symbols = Symbols.index<ColumnKind>();
            var kinds = alloc<ColumnKind>(count);
            var choices = symbols.View.ToArray().Map(s => (s.Expr.Format(), s.Kind)).ToDictionary();
            for(var i=0; i<count; i++)
            {
                ref readonly var label = ref skip(labels,i);
                if(choices.TryGetValue(label, out var k))
                    seek(kinds,i) = k;
            }
            return new TableHeader(kind, kinds, labels);
        }
    }
}