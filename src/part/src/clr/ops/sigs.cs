//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Root;
    using static memory;
    using static root;

    partial struct Clr
    {
        public static Index<CliSig> sigs(MethodInfo[] src)
        {
            var count = root.count(src);
            if(count==0)
                return default;

            var dst = sys.alloc<CliSig>(count);
            sigs(src, dst);
            return dst;
        }

        [Op]
        public static void sigs(MethodInfo[] src, Span<CliSig> dst)
        {
            var k = min(count(src), count(dst));
            if(k != 0)
            {
                ref readonly var input = ref first(src);
                ref var output = ref first(dst);
                for(var i=0; i<k; i++)
                    seek(output,i) = sig(skip(input,i));
            }
        }
    }
}