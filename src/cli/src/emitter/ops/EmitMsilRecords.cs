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

    partial class ImageDataEmitter
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

        public Index<MsilRow> EmitMsilRows(Assembly src)
        {
            var srcPath = FS.path(src.Location);
            var processing = Wf.Running(srcPath);
            using var reader = CliDataReader.create(srcPath);
            var methods = reader.ReadMsil();
            var view = methods.View;
            var count = (uint)methods.Length;
            if(count != 0)
            {
                var dst = Db.Table<MsilRow>(src.GetSimpleName());
                var flow = Wf.EmittingTable<MsilRow>(dst);
                Tables.emit(methods,dst);
                Wf.EmittedTable<MsilRow>(flow, count);
            }

            Wf.Ran(processing, src);

            return methods;
        }

    }
}