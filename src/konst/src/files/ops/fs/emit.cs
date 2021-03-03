//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Part;
    using static memory;

    partial struct FS
    {
        [Op]
        public static void emit(ListedFiles src, FS.FilePath dst)
        {
            var records = src.View;
            var count = records.Length;
            var header = Table.header<ListedFileField>();
            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);
            for(var i=0u; i<count; i++)
                writer.WriteLine(FS.format(skip(records,i)));
        }
    }
}