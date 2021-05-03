//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Part;


    [ApiHost]
    public readonly struct Guids
    {
        [MethodImpl(Inline), Op]
        public static Guid define(ReadOnlySpan<byte> src)
            => new Guid(src);

        [Op]
        public static Guid define(string src)
        {
            if(Guid.TryParse(src, out var dst))
                return dst;
            else
                return Guid.Empty;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> serialize(Guid src)
        {
            var dst = Cells.alloc(w128).Bytes;
            if(src.TryWriteBytes(dst))
                return dst;
            else
                return default;
        }
    }
}