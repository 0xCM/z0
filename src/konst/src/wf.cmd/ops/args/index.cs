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

    partial struct CmdArgs
    {
        public static CmdArgIndex index<T>(T src)
            where T : struct, ICmdSpec<T>
                => typeof(T).DeclaredInstanceFields().Select(f => new CmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));

        /// <summary>
        /// Creates a <see cref='CmdArgIndex'/> collection from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static CmdArgIndex index(params CmdArg[] src)
            => new CmdArgIndex(src);
   }
}
