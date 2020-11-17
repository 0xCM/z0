//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        public static CmdArgs args<T>(T src)
            where T : struct, ICmdSpec<T>
                => typeof(T).DeclaredInstanceFields().Select(f => new CmdArg(f.Name, f.GetValue(src)));

        public static CmdArgs args<K,T>(CmdSpec<K,T> src)
            where K : unmanaged
            where T : struct, ICmdSpec<T>
                => new CmdArgs(src.Args.Storage.Map(x => new CmdArg(x.Kind.ToString(), x.Value.ToString())));

        /// <summary>
        /// Creates a <see cref='CmdArgs'/> collection from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static CmdArgs args(params CmdArg[] src)
            => new CmdArgs(src);
    }
}