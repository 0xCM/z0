//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial struct Cmd
    {
        const string InvalidOption = "Option text invalid";

        const string Blank = "The source text appears blank";

        [Op]
        public static Outcome parse(string src, ArgProtocol protocol, out ToolExecSpec dst)
        {
            var parts = TextTools.split(src, protocol.Prefix);
            var count = parts.Length;
            var result = Outcome.Success;
            dst = default;
            ushort pos = 0;
            if(count != 0)
            {
                ref readonly var part = ref first(parts);
                var id = cmdid(part);
                var options = list<ToolCmdArg>();
                for(var i=1; i<count; i++)
                {
                    ref readonly var next = ref skip(parts,i);
                    if(!blank(next))
                    {
                        result = parse(pos++, next, protocol.Qualifier, out var option);
                        if(result)
                            options.Add(option.Value);
                        else
                            break;
                    }
                }
                dst = new ToolExecSpec(id, options.ToArray());
            }
            else
            {
                result = (false, Blank);
            }

            return result;
        }

        [Op]
        public static Outcome parse(ReadOnlySpan<ArgPrefix> prefixes, CmdLine src, out ToolExecSpec dst)
        {
            var parts = src.Parts;
            var count = parts.Length;
            var args = list<ToolCmdArg>();
            for(ushort i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                if(parse(prefixes, i, part, out var arg))
                {
                    args.Add(arg);
                }
            }
            dst = new ToolExecSpec(CmdId.from(""), args.Array());
            return false;
        }

        [Op]
        public static Outcome parse(ReadOnlySpan<ArgPrefix> prefixes, ushort index, CmdLinePart part, out ToolCmdArg arg)
        {
            var data = part.Chars;
            if(parse(prefixes, part.Chars, out ArgPrefix prefix))
            {
                var length = prefix.Length;
                arg = new ToolCmdArg(index, prefix, "name", "value");
                return true;
            }
            arg = default;
            return false;
        }

        [Op]
        public static Outcome parse(ReadOnlySpan<ArgPrefix> matches, ReadOnlySpan<char> src, out ArgPrefix dst)
        {
            dst = default;
            var kSrc = (uint)src.Length;
            for(var i=0; i<kSrc; i++)
            {
                ref readonly var match = ref skip(matches,i);
                if(prefix(src) == match)
                {
                    dst = match;
                    return true;
                }
            }
            return false;
        }

        [Op]
        public static Outcome parse(ushort pos, string src, ArgQualifier qualifier, out ToolCmdArg dst)
        {
            var result = Outcome.Success;
            dst = default;
            try
            {
                var i = src.IndexOf(qualifier);
                if(i == NotFound)
                    dst = new ToolCmdArg(pos, src);
                else
                    dst = new ToolCmdArg(pos, src.LeftOfIndex(i), src.RightOfIndex(i));
            }
            catch(Exception e)
            {
                result = e;
            }
            return result;
        }

    }
}