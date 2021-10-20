//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial struct strings
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool store<S>(ReadOnlySpan<S> src, uint offset, StringBuffer<S> dst)
            where S : unmanaged
        {
            var available = (long)dst.Length - (long)offset;
            var requested = src.Length;
            if(requested <= available)
            {
                var j = offset;
                for(var i=0; i<requested; i++)
                    dst[j++] = skip(src,i);
                return true;
            }
            return false;
        }

        [MethodImpl(Inline), Op]
        public static bool store(ReadOnlySpan<char> src, uint offset, StringBuffer dst)
        {
            var available = (long)dst.Length - (long)offset;
            var requested = src.Length;
            if(requested <= available)
            {
                var j = offset;
                for(var i=0; i<requested; i++)
                    dst[j++] = skip(src,i);
                return true;
            }
            return false;
        }
    }
}