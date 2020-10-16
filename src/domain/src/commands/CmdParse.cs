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

    [ApiHost(ApiNames.CmdParse, true)]
    public readonly partial struct CmdParse
    {
        const string CmdIdNotFound = "Command identifier not found";

        const string InvalidOption = "Option text invalid";

        const char OptionDelimiter = Chars.Colon;

        /// <summary>
        /// Parses a <see cref='CmdId'/> from a command identifier
        /// </summary>
        /// <param name="src">The command identifier</param>
        [Op]
        public static ParseResult<CmdId> id(string src)
        {
            var id = string.IsInterned(src);
            if(id != null)
                return parsed(src, new CmdId(src));
            else
                return unparsed<CmdId>(src,CmdIdNotFound);
        }

        [Op]
        public static ParseResult<CmdOption> option(string src)
        {
            try
            {
                var i = src.IndexOf(OptionDelimiter);
                if(i == NotFound)
                    return parsed(src,new CmdOption(src));
                else
                    return parsed(src, new CmdOption(src.LeftOfIndex(i), src.RightOfIndex(i)));
            }
            catch(Exception e)
            {
                return unparsed<CmdOption>(src,e);
            }
        }


        [Op]
        public static ParseResult<CmdSpec> spec(string src)
        {
            var fail = unparsed<CmdSpec>(src);
            var lines = @readonly(text.split(src, Eol));
            var count = lines.Length;
            if(count != 0)
            {
                ref readonly var line = ref first(lines);
                var id = CmdParse.id(line);
                if(!id)
                    return id.WithReason(CmdIdNotFound).As<CmdSpec>();

                var options = list<CmdOption>();
                for(var i = 1; i<count; i++)
                {
                    ref readonly var next = ref skip(lines,i);
                    if(!text.blank(next))
                    {
                        var option = CmdParse.option(next);
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