//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    [ApiHost]
    public readonly struct ApiResolutions
    {
        [Op]
        public static uint MethodCount(ReadOnlySpan<ResolvedPart> src)
        {
            var counter = 0u;
            var k0 = (uint)src.Length;
            for(var i0=0u; i0<k0; i0++)
            {
                ref readonly var part = ref skip(src,i0);
                var hosts = part.Hosts.View;
                var k1 = (uint)hosts.Length;
                for(var i1=0u; i1<k1; i1++)
                    counter += skip(hosts, i1).Methods.Count;
            }
            return counter;
        }

        [Op]
        public static uint methods(ReadOnlySpan<ResolvedPart> src, Span<ResolvedMethod> dst)
        {
            var k0 = src.Length;
            var counter = 0u;
            for(var i0=0; i0<k0; i0++)
            {
                ref readonly var part = ref skip(src,i0);
                var hosts = part.Hosts.View;
                var k1 = (uint)hosts.Length;
                for(var i1=0u; i1<k1; i1++)
                {
                    var methods = skip(hosts,i1).Methods.View;
                    var k2 = methods.Length;
                    for(var i2=0; i2<k2; i2++)
                        seek(dst, counter++) = skip(methods,i2);
                }
            }
            return counter;
        }

        public static uint describe(ReadOnlySpan<ResolvedMethod> src, Span<ResolvedMethodInfo> dst)
        {
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(src,i);
                ref var info = ref seek(dst,i);
                info.EntryPoint = method.EntryPoint;
                info.Uri = method.Uri.Format();
                info.DisplaySig = method.Method.DisplaySig().Format();
            }
            dst.Sort();
            return count;
        }

        public static Index<ResolvedMethod> methods(ReadOnlySpan<ResolvedPart> src)
        {
            var dst = alloc<ResolvedMethod>(MethodCount(src));
            methods(src,dst);
            return dst;
        }
    }
}