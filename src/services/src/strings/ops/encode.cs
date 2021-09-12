//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    partial struct StringTables
    {
        public static void encode(StringTableSpec src, StreamWriter dst)
        {
            var entries = src.Entries;
            var count = entries.Length;
            dst.WriteLine(string.Format("namespace {0}",src.Namespace));
            dst.WriteLine(Chars.LBrace);
            dst.WriteLine(string.Format("    using {0};", "System"));
            dst.WriteLine();
            dst.WriteLine(string.Format("    using static {0};", "core"));
            dst.WriteLine();
            dst.WriteLine(create(src.TableName, src.Entries).Format(4));
            dst.WriteLine(Chars.RBrace);
        }
    }
}