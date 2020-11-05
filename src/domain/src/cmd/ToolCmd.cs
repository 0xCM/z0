//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct ToolCmd
    {
        [MethodImpl(Inline), Op]
        public static ToolId toolid(string name)
            => new ToolId(name);

        [MethodImpl(Inline), Op]
        public static ToolId toolid(Type t)
            => new ToolId(t.Name);

        [MethodImpl(Inline), Op]
        public static CmdId cmdid(string name)
            => new CmdId(name);

        [MethodImpl(Inline), Op]
        public static CmdId cmdid(Type t)
            => t.Tag<ToolCmdAttribute>().MapValueOrElse(x => new CmdId(x.ToolName), () => CmdId.Empty);

        [MethodImpl(Inline)]
        public static ToolId toolid<T>()
            where T : struct, IToolCmd<T>
                => new ToolId(typeof(T).Name);

        [MethodImpl(Inline)]
        public static CmdId cmdid<T>()
            where T : struct, IToolCmd<T>
                => cmdid(typeof(T));
    }
}