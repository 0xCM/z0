//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [Op]
        public static bool lookup(CmdArgs src, string name, out CmdArg dst)
        {
            for(var i=0; i<src.Count; i++)
            {
                ref readonly var arg = ref src[i];
                if(text.equals(arg.Name, name))
                {
                    dst=arg;
                    return true;
                }
            }
            dst = CmdArg.Empty;
            return false;
        }

        [Op]
        public static ParseResult<CmdArg> arg(string src, char specifier = ' ')
        {
            try
            {
                var i = src.IndexOf(specifier);
                if(i == NotFound)
                    return parsed(src, new CmdArg(src));
                else
                    return parsed(src, new CmdArg(src.LeftOfIndex(i), src.RightOfIndex(i)));
            }
            catch(Exception e)
            {
                return unparsed<CmdArg>(src,e);
            }
        }


        [Op]
        public static ParseResult<CmdSpec> parse(string src, string delimiter = EmptyString, char specifier = ' ')
        {
            var fail = unparsed<CmdSpec>(src);
            var parts = @readonly(text.split(src, delimiter));
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
                        var option = arg(next, specifier);
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