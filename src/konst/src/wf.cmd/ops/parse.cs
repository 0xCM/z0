//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct Cmd
    {
        [Op]
        public static CmdParser parser(IWfShell wf)
            => CmdParser.create(wf);

        [Op]
        public static ParseResult<CmdExecSpec> parse(string src, string delimiter = EmptyString, char qualifier = ' ')
        {
            var fail = unparsed<CmdExecSpec>(src);
            var parts = text.split(src, delimiter).View;
            var count = parts.Length;
            ushort pos = 0;
            if(count != 0)
            {
                ref readonly var part = ref first(parts);
                var id = Cmd.id(part);
                var options = list<CmdArg>();
                for(var i=1; i<count; i++)
                {
                    ref readonly var next = ref skip(parts,i);
                    if(!text.blank(next))
                    {
                        var option = arg(pos++,next, qualifier);
                        if(option)
                            options.Add(option.Value);
                        else
                            return fail.WithReason(InvalidOption);
                    }
                }
                return parsed(src, new CmdExecSpec(id, options.ToArray()));
            }

            return fail;
        }

        [Op]
        static ParseResult<CmdArg> arg(ushort pos, string src, char qualifier = ' ')
        {
            try
            {
                var i = src.IndexOf(qualifier);
                if(i == NotFound)
                    return parsed(src, new CmdArg(pos, src));
                else
                    return parsed(src, new CmdArg(pos, src.LeftOfIndex(i), src.RightOfIndex(i)));
            }
            catch(Exception e)
            {
                return unparsed<CmdArg>(src,e);
            }
        }

        internal const string InvalidOption = "Option text invalid";
    }
}