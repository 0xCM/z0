//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Cmd
    {
        public static CmdImplMap<T> implmap<T>(Type src)
            where T : unmanaged
        {
            var dst = new CmdImplMap<T>();
            var methods = src.InstanceMethods().Tagged<CmdImplAttribute>().ToReadOnlySpan();
            var count = methods.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var cmd = (T)method.Tag<CmdImplAttribute>().Require().Cmd;
                dst[cmd] = method;
            }
            return dst;
        }
    }
}