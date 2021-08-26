//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    partial struct StringTables
    {
        static void index(uint margin, in StringTable src, ITextBuffer dst)
        {
            var count = src.EntryCount;
            dst.IndentLine(margin, string.Format("public enum Index : uint"));
            dst.IndentLine(margin, Chars.LBrace);
            margin+=4;
            for(var i=0u; i<count; i++)
            {
                ref readonly var id = ref src.Identifier(i);
                if(id.IsEmpty)
                    break;
                dst.IndentLineFormat(margin, "{0}={1},", id, i);
            }
            margin-=4;
            dst.IndentLine(margin, Chars.RBrace);
        }
    }
}