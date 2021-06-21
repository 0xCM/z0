//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdOp cmdop(string name, CliToken id)
            => new CmdOp(name,id);

        [Op]
        public static Index<CmdOp> cmdops(Assembly[] src)
        {
            var methods = src.Methods().Tagged<CmdOpAttribute>();
            var count = methods.Length;
            var buffer = alloc<CmdOp>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var tag = method.Tag<CmdOpAttribute>().Require();
                seek(dst,i) = cmdop(tag.CommandName, method);
            }
            return buffer;
        }
    }
}