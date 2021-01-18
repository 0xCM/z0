//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Part;
    using static memory;

    partial struct Resources
    {
        public static ApiHostRes from(ApiHostCode src)
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
    }
}