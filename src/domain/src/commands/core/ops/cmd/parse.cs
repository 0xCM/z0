//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [Op]
        public static ParseResult<CmdSpec> parse(string src)
        {
            var fail = unparsed<CmdSpec>(src);
            var parts = @readonly(text.split(src, Space));
            var count = parts.Length;
            if(count != 0)
            {
                ref readonly var part = ref first(parts);
                var id = Cmd.id(part);

                var options = list<CmdArg>();
                for(var i = 1; i<count; i++)
                {
                    ref readonly var next = ref skip(parts,i);
                    if(!text.blank(next))
                    {
                        var option = Cmd.arg(next);
                        if(option)
                            options.Add(option.Value);
                        else
                            return fail.WithReason(InvalidOption);
                    }
                }
                return parsed(src, new CmdSpec(id, options.ToArray()));
            }

            return fail;
        }
    }
}