//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static z;
    using static ApiDataModel;

    [ApiHost(ApiNames.ApiData, true)]
    public readonly struct ApiData
    {
        [Op]
        public static uint emit(ReadOnlySpan<CodeBlockDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(CodeBlockDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public static CodeBlockDescriptor descriptor(in ApiCodeBlock src)
        {
            var dst = new CodeBlockDescriptor();
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.Base;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ApiMemberEntity entity(in ApiMember src)
        {
            var dst = new ApiMemberEntity();
            return store(src,ref dst);
        }

        [MethodImpl(Inline), Op]
        public static ApiMemberEntity entity(ApiMember src)
            => entity(in src);

        [Op]
        public static ApiHostMemberEntities entities(in ApiHostCatalog src)
        {
            var dst = new ApiHostMemberEntities();
            dst.Host = src.Host.Uri;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiMemberEntity store(in ApiMember src, ref ApiMemberEntity dst)
        {
            dst.Address = src.Address;
            dst.MetaUri = src.MetaUri;
            dst.ApiKind = src.ApiKind;
            dst.Host = src.Host;
            dst.Cil = src.Cil;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CodeBlockDescriptor store(in ApiCodeBlock src, ref CodeBlockDescriptor dst)
        {
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.Base;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return ref dst;
        }

        [Op]
        public static CodeBlockDescriptor[] BlockDescriptors(IWfShell wf)
        {
            var archive = ApiFiles.hex(wf);
            var files = @readonly(archive.List().Storage);
            var dst = list<CodeBlockDescriptor>();
            var count = files.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var content = @readonly(archive.Read(file.Path));
                var kBlock = content.Length;
                var buffer = alloc<CodeBlockDescriptor>(kBlock);
                var target = span(buffer);
                for(var j=0u; j<kBlock; j++)
                    store(skip(content,j), ref seek(target,j));
                dst.AddRange(buffer);
            }
            return dst.OrderBy(x => x.Base).ToArray();
        }

        [Op]
        public static CodeBlockDescriptor[] BlockDescriptors(FS.FolderPath src)
        {
            var archive = ApiFiles.hex(src);
            var files = archive.List();
            var dst = list<ApiDataModel.CodeBlockDescriptor>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => descriptor(x)));
            return dst.OrderBy(x => x.Base).ToArray();
        }
    }
}