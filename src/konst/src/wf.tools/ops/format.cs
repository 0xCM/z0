//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct CmdTools
    {
        [Formatter]
        public static string format(CmdToolArg src)
            => string.Format("{0}{2}", Cmd.format(src.Option), src.Value);

        [Formatter]
        public static string format(CmdToolArg src, CmdArgPrefix delimiter, char specifier)
            => string.Format("{0}{1}{2}{3}", Cmd.format(delimiter), Cmd.format(src.Option), specifier, src.Value);

        public static string format<K,V>(CmdToolArg<K,V> src, char specifier)
            where K : unmanaged
                => string.Format("{0}{1}{2}", src.Option, specifier, src.Value);
    }
}