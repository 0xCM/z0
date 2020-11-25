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

    partial struct Tooling
    {
        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline)]
        public static CmdHostId toolid<T>()
            => new CmdHostId(typeof(T).Name);

        [MethodImpl(Inline), Op]
        public static CmdHostId toolid(Type src)
            => new CmdHostId(src.Name);

        [MethodImpl(Inline), Op]
        public static CmdHostId toolid(string src)
            => new CmdHostId(src);
    }
}