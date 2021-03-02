//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ToolCmd
    {
        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline)]
        public static ToolId toolid<T>()
            => new ToolId(typeof(T).Name);

        [MethodImpl(Inline), Op]
        public static ToolId toolid(Type src)
            => new ToolId(src.Name);

        [MethodImpl(Inline), Op]
        public static ToolId toolid(string src)
            => new ToolId(src);
    }
}