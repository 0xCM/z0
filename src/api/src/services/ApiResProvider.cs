//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

    public sealed class ApiResProvider : AppService<ApiResProvider>
    {
        public FS.FilePath ResPackPath()
            => Db.Package("respack") + FS.file("z0.respack", FS.Dll);

        public MemoryFile MapResPack()
            => MemoryFiles.map(ResPackPath());

        public Index<SpanResAccessor> ResPackAccessors()
        {
            var path = ResPackPath();
            var flow = Wf.Running(Msg.LoadingRespackAccessors.Format(path));
            if(!path.Exists)
                Throw.sourced(FS.Msg.DoesNotExist.Format(path));
            var assembly = Assembly.LoadFrom(path.Name);
            var loaded = SpanRes.accessors(assembly);
            Wf.Ran(flow, Msg.LoadedRespackAccessors.Format(loaded.Count, path));
            return loaded;
        }

        public static ApiHostRes hosted(ApiHostBlocks src)
        {
            var count = src.Length;
            var buffer = alloc<BinaryResSpec>(count);
            var dst = span(buffer);
            var blocks = src.Blocks.View;
            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref skip(blocks,i);
                var name = LegalIdentityBuilder.code(code.Id);
                seek(dst,i) = new BinaryResSpec(name, code.Encoded);
            }
            return new ApiHostRes(src.Host, buffer);
        }

        public ApiHostRes Hosted(ApiHostBlocks src)
            => hosted(src);
    }
}