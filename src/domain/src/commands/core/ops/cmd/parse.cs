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
        [Op]
        public static ParseResult<CmdSpec> parse(string src)
        {
            var fail = unparsed<CmdSpec>(src);
            var lines = @readonly(text.split(src, Eol));
            var count = lines.Length;
            if(count != 0)
            {
                ref readonly var line = ref first(lines);
                var id = Cmd.id(line);
                if(!id)
                    return id.WithReason(Cmd.CmdIdNotFound).As<CmdSpec>();

                var options = list<CmdOption>();
                for(var i = 1; i<count; i++)
                {
                    ref readonly var next = ref skip(lines,i);
                    if(!text.blank(next))
                    {
                        var option = Cmd.option(next);
                        if(option)
                            options.Add(option.Value);
                        else
                            return fail.WithReason(InvalidOption);
                    }
                }
                return parsed(src, new CmdSpec(id.Value, options.ToArray()));
            }

            return fail;
        }
    }
}