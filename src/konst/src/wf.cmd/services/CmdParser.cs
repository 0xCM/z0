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
    public sealed class CmdParser : WfService<CmdParser,ICmdParser>, ICmdParser
    {
        readonly Index<ArgPrefix> Prefixes;

        readonly Index<ArgQualifier> Qualifiers;

        public CmdParser()
        {

        }

        public Outcome Parse(CmdLine src, out CmdSpec dst)
            => parse(Prefixes, src, out dst);

        public Outcome Parse(ReadOnlySpan<char> src, out ArgPrefix dst)
            => parse(Prefixes, src, out dst);

        [Op]
        static Outcome parse(ReadOnlySpan<ArgPrefix> prefixes, CmdLine src, out CmdSpec dst)
        {
            var parts = src.Parts;
            var count = parts.Length;
            var args = z.list<CmdArg>();
            for(ushort i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                if(parse(prefixes, i, part, out var arg))
                {
                    args.Add(arg);
                }
            }
            dst = new CmdSpec(Cmd.id(""), args.Array());
            return false;
        }

        [Op]
        static Outcome parse(ReadOnlySpan<ArgPrefix> prefixes, ushort index, CmdLinePart part, out CmdArg arg)
        {
            var data = part.Chars;
            if(parse(prefixes, part.Chars, out ArgPrefix prefix))
            {
                var length = prefix.Length;
                arg = new CmdArg(index, prefix, "name", "value");
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
                if(Cmd.prefix(src) == match)
                {
                    dst = match;
                    return true;
                }
            }
            return false;
        }
    }
}