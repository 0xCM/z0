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
        [MethodImpl(Inline), Op]
        public static CmdArg<T> arg<T>(ushort index, T value)
            => (index,value);

        [MethodImpl(Inline), Op]
        public static CmdArgs args(CmdArg[] src)
            => src;

        public static CmdArgs args(string[] src)
        {
            var dst = alloc<CmdArg>(src.Length);
            for(ushort i=0; i<src.Length; i++)
                seek(dst,i) = new CmdArg((ushort)i,skip(src,i));
            return dst;
        }
    }
}