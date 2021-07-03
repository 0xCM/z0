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
        [Op, Closures(Closure)]
        public static CmdSpec<K> spec<K>(K id, StringIndex args)
            where K : unmanaged
                => new CmdSpec<K>(id,args);

        [Op, MethodImpl(Inline)]
        public static CmdSpec spec(string name, CmdArgs args)
            => new CmdSpec(name, args);

        [Op]
        public static CmdSpec spec(string input)
        {
            var i = input.IndexOf(Chars.Space);
            var args = CmdArgs.Empty;
            var name = input;
            if(i != NotFound)
            {
                name = TextTools.left(input,i);
                var right = TextTools.right(input,i);
                if(nonempty(right))
                    args = Cmd.args(right.Split(Chars.Space));
            }
            return new CmdSpec(name,args);
        }
    }
}