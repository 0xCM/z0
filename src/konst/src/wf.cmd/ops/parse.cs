//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

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
                if(string.Equals(arg.Name, name, StringComparison.InvariantCultureIgnoreCase))
                {
                    dst=arg;
                    return true;
                }
            }
            dst = CmdArg.Empty;
            return false;
        }

        [Op]
        public static CmdArg parse(string src, char delimiter, char argspec)
        {
            var content = src.Trim();
            if(!String.IsNullOrWhiteSpace(content))
            {
                if(src[0] == delimiter)
                {
                    var parts = src.Substring(1).Split(argspec, StringSplitOptions.RemoveEmptyEntries);

                    if(parts.Length == 2)
                        return new CmdArg(parts[0], parts[1]);
                    else if(parts.Length == 0)
                        return CmdArg.Empty;
                    else
                    {
                        var dst = parts[0];
                        for(var i=1; i<parts.Length; i++)
                            dst += string.Format(" {0}", parts[i]);
                        return (EmptyString, dst);
                    }
                }
                else
                    return (EmptyString, src);
            }

            return CmdArg.Empty;
        }

        [Op]
        public static CmdArgs parse(string[] src, char delimiter, char argspec)
        {
            if(src.Length != 0)
            {
                var dst = new List<CmdArg>();
                foreach(var item in src)
                {
                    var parsed = parse(item, delimiter, argspec);
                    if(parsed.IsNonEmpty)
                        dst.Add(parsed);
                }

                if(dst.Count != 0)
                    return dst.ToArray();
            }
            return CmdArgs.Empty;
        }


        [MethodImpl(Inline), Op]
        public static CmdParser parser()
            => CmdParser.create();

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