//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Tooling
    {
        [Formatter]
        public static string format(ToolArg src)
            => string.Format("{0}{2}", CmdOptions.format(src.Option), src.Value);

        [Formatter]
        public static string format(ToolArg src, CmdArgPrefix delimiter, char specifier)
            => string.Format("{0}{1}{2}{3}", CmdArgs.format(delimiter), CmdOptions.format(src.Option), specifier, src.Value);

        public static string format<K,V>(ToolArg<K,V> src, char specifier)
            where K : unmanaged
                => string.Format("{0}{1}{2}", src.Option, specifier, src.Value);
    }
}