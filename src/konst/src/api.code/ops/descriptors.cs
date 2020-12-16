//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiCode
    {
        [Op]
        public static ApiCodeDescriptor[] descriptors(IWfShell wf)
        {
            var archive = WfArchives.hex(wf);
            var files = @readonly(archive.Listing().Storage);
            var dst = list<ApiCodeDescriptor>();
            var count = files.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var content = @readonly(archive.Read(file.Path));
                var kBlock = content.Length;
                var buffer = alloc<ApiCodeDescriptor>(kBlock);
                var target = span(buffer);
                for(var j=0u; j<kBlock; j++)
                    store(skip(content,j), ref seek(target,j));
                dst.AddRange(buffer);
            }
            return dst.OrderBy(x => x.Base).ToArray();
        }

        [Op]
        public static ApiCodeDescriptor[] descriptors(IWfShell wf, params PartId[] parts)
        {
            var archive = WfArchives.hex(wf);
            wf.Status(parts.Length);
            var dst  = list<ApiCodeDescriptor>();
            foreach(var part in parts)
            {

                var files = @readonly(archive.Files(part));
                var count = files.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var file = ref skip(files,i);
                    var content = @readonly(archive.Read(file));
                    var kBlock = content.Length;
                    var buffer = alloc<ApiCodeDescriptor>(kBlock);
                    var target = span(buffer);
                    for(var j=0u; j<kBlock; j++)
                        store(skip(content,j), ref seek(target,j));
                    dst.AddRange(buffer);
                }
            }

            return dst.OrderBy(x => x.Base).ToArray();
        }

        [Op]
        public static ApiCodeDescriptor[] descriptors(FS.FolderPath src)
        {
            var archive = WfArchives.hex(src);
            var files = archive.Listing();
            var dst = list<ApiCodeDescriptor>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => descriptor(x)));
            return dst.OrderBy(x => x.Base).ToArray();
        }

        [MethodImpl(Inline), Op]
        static ApiCodeDescriptor descriptor(in ApiCodeBlock src)
        {
            var dst = new ApiCodeDescriptor();
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.Base;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiCodeDescriptor store(in ApiCodeBlock src, ref ApiCodeDescriptor dst)
        {
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.Base;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return ref dst;
        }
    }
}