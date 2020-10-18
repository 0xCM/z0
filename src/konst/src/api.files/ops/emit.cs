//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ApiFiles
    {
        [MethodImpl(Inline)]
        public static ApiHexWriter hexwriter<H>(FS.FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(ApiHexWriter))
                return new ApiHexWriter(dst);
            else
                throw no<H>();
        }


        [Op]
        public static void emit(ListedFiles src, FS.FilePath dst)
        {
            var records = src.View;
            var count = records.Length;
            var header = Table.header<ListedFileField>();
            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(ApiFiles.format(record));
            }
        }
    }
}