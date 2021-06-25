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

        [Op]
        public static ParseResult<ToolExecSpec> parse(string src, string delimiter = EmptyString, char qualifier = ' ')
        {
            var fail = ParseResult.unparsed<ToolExecSpec>(src);
            var parts = TextTools.split(src, delimiter);
            var count = parts.Length;
            ushort pos = 0;
            if(count != 0)
            {
                ref readonly var part = ref first(parts);
                var id = CmdId.from(part);
                var options = list<ToolCmdArg>();
                for(var i=1; i<count; i++)
                {
                    ref readonly var next = ref skip(parts,i);
                    if(!TextTools.blank(next))
                    {
                        var option = ToolArgs.parse(pos++,next, qualifier);
                        if(option)
                            options.Add(option.Value);
                        else
                            return fail.WithReason(InvalidOption);
                    }
                }
                return ParseResult.parsed(src, new ToolExecSpec(id, options.ToArray()));
            }

            return fail;
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
                if(ArgPrefix.define(src) == match)
                {
                    dst = match;
                    return true;
                }
            }
            return false;
        }
    }
}