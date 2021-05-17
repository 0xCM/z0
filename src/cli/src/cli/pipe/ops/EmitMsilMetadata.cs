//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

    partial class CliPipe
    {
        public uint EmitMsilMetadata()
            => EmitMsilMetadata(Wf.Components);

        public uint EmitMsilMetadata(ReadOnlySpan<Assembly> src)
        {
            var total = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitMsilMetadata(skip(src,i));
            return total;
        }

        public void ClearMsilMetadata()
        {
            MsilDir().Clear();
        }

        public FS.FolderPath MsilDir()
            => Db.TableDir<MsilMetadata>();

        public FS.FilePath MsilPath(Assembly src)
            => Db.Table<MsilMetadata>(src.GetSimpleName());

        public Index<MsilMetadata> EmitMsilMetadata(Assembly src)
        {
            var methods = Index<MsilMetadata>.Empty;
            var srcPath = FS.path(src.Location);
            if(ImageMetadata.valid(srcPath))
            {
                var processing = Wf.Running(srcPath);
                using var reader = ImageMetadata.reader(srcPath);
                methods = reader.ReadMsil();
                var view = methods.View;
                var count = (uint)methods.Length;
                if(count != 0)
                {
                    var dst = MsilPath(src);
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