//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;

    using F = ListedFileField;

    partial struct FS
    {
        public static void save(in ListedFiles src, Z0.FilePath dst)
        {
            var records = z.span(src.Data);
            var count = records.Length;
            var header = Table.header<F>();
            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                writer.WriteLine(format(record));
            }    
        }
    }
}