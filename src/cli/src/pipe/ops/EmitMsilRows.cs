//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;
    using static Images;

    partial class ImageMetaPipe
    {
        public uint EmitMsilRows()
            => EmitMsilRows(Wf.Components);

        public uint EmitMsilRows(ReadOnlySpan<Assembly> src)
        {
            var total = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitMsilRows(skip(src,i));
            return total;
        }

        public Index<MsilMetadata> EmitMsilRows(Assembly src)
        {
            var methods = Index<MsilMetadata>.Empty;
            var srcPath = FS.path(src.Location);
            if(ImageMetaReader.HasMetadata(srcPath))
            {
                var processing = Wf.Running(srcPath);
                using var reader = ImageMetaReader.create(srcPath);
                methods = reader.ReadMsil();
                var view = methods.View;
                var count = (uint)methods.Length;
                if(count != 0)
                {
                    var dst = Db.Table<MsilMetadata>(src.GetSimpleName());
                    var flow = Wf.EmittingTable<MsilMetadata>(dst);
                    Tables.emit(methods,dst);
                    Wf.EmittedTable<MsilMetadata>(flow, count);
                }

                Wf.Ran(processing, src);
            }
            return methods;
        }
    }
}