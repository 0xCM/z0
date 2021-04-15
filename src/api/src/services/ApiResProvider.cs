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

    public sealed class ApiResProvider : WfService<ApiResProvider>
    {
        public Index<ApiResAccessor> PackagedCode()
        {
            var package = Db.Package("respack");
            var path = package + FS.file("z0.respack.dll");
            if(!path.Exists)
                root.@throw(FS.Msg.DoesNotExist.Format(path));
            var assembly = Assembly.LoadFrom(path.Name);
            return Resources.accessors(assembly);
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