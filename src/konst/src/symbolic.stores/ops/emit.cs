//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct SymbolStores
    {
        [Op]
        public static void emit(ReadOnlySpan<TokenRecord> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            var header = text.concat($"Identifier".PadRight(20), "| ", "Token".PadRight(20), "| ", "Meaning");
            writer.WriteLine(header);
            for(var i=1; i<count; i++)
            {
                ref readonly var token = ref skip(src,i);
                var line = text.concat(token.Name.Format().PadRight(20), "| ", token.Value.PadRight(20), "| ", token.Description);
                writer.WriteLine(line);
            }
        }
    }
}