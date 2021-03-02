//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public sealed class CmdParser : WfService<CmdParser,IToolCmdParser>, IToolCmdParser
    {
        readonly Index<ArgPrefix> Prefixes;

        readonly Index<ArgQualifier> Qualifiers;

        public CmdParser()
        {

        }

        const string InvalidOption = "Option text invalid";

        [Op]
        public static ParseResult<ToolExecSpec> parse(string src, string delimiter = EmptyString, char qualifier = ' ')
        {
            var fail = root.unparsed<ToolExecSpec>(src);
            var parts = text.split(src, delimiter).View;
            var count = parts.Length;
            ushort pos = 0;
            if(count != 0)
            {
                ref readonly var part = ref first(parts);
                var id = Cmd.id(part);
                var options = root.list<ToolCmdArg>();
                for(var i=1; i<count; i++)
                {
                    ref readonly var next = ref skip(parts,i);
                    if(!text.blank(next))
                    {
                        var option = ToolCmd.arg(pos++,next, qualifier);
                        if(option)
                            options.Add(option.Value);
                        else
                            return fail.WithReason(InvalidOption);
                    }
                }
                return root.parsed(src, new ToolExecSpec(id, options.ToArray()));
            }

            return fail;
        }

        public Outcome Parse(CmdLine src, out ToolExecSpec dst)
            => parse(Prefixes, src, out dst);

        public Outcome Parse(ReadOnlySpan<char> src, out ArgPrefix dst)
            => parse(Prefixes, src, out dst);

        [Op]
        static Outcome parse(ReadOnlySpan<ArgPrefix> prefixes, CmdLine src, out ToolExecSpec dst)
        {
            var parts = src.Parts;
            var count = parts.Length;
            var args = root.list<ToolCmdArg>();
            for(ushort i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                if(parse(prefixes, i, part, out var arg))
                {
                    args.Add(arg);
                }
            }
            dst = new ToolExecSpec(Cmd.id(""), args.Array());
            return false;
        }

        [Op]
        static Outcome parse(ReadOnlySpan<ArgPrefix> prefixes, ushort index, CmdLinePart part, out ToolCmdArg arg)
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
        static Outcome parse(ReadOnlySpan<ArgPrefix> matches, ReadOnlySpan<char> src, out ArgPrefix dst)
        {
            dst = default;
            var kSrc = (uint)src.Length;
            for(var i=0; i<kSrc; i++)
            {
                ref readonly var match = ref skip(matches,i);
                if(ToolCmd.prefix(src) == match)
                {
                    dst = match;
                    return true;
                }
            }
            return false;
        }
    }
}