//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    partial struct ApiCode
    {
        public static void emit(IWfShell wf, ReadOnlySpan<ApiCodeDescriptor> src)
        {
            var dst = wf.Db().IndexTable("apihex.index");
            var count = emit(src, dst);
            wf.EmittedTable<ApiCodeDescriptor>(count, dst);
        }

        [Op]
        public static uint emit(ReadOnlySpan<ApiCodeDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(ApiCodeDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
            return count;
        }
    }
}