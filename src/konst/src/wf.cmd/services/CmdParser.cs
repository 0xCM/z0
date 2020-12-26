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
        readonly Index<string> Prefixes;

        readonly Index<char> Qualifiers;

        public CmdParser()
        {

        }

        public bool Parse(CmdLine src, out CmdSpec dst)
            => RunParse(src, out dst);

        public bool Parse(ReadOnlySpan<char> src, out ArgPrefix dst)
            => RunParse(src, out dst);

        [Op]
        bool RunParse(CmdLine src, out CmdSpec dst)
        {
            var parts = src.Parts;
            var count = parts.Length;
            for(ushort i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                if(RunParse(i, part, out var arg))
                {

                }
            }
            dst = CmdSpec.Empty;
            return false;
        }

        [Op]
        bool RunParse(ushort index, CmdLinePart part, out CmdArg arg)
        {
            var data = part.Chars;
            if(Parse(part.Chars, out ArgPrefix prefix))
            {

            }
            arg = default;
            return true;
        }

        [Op]
        bool RunParse(ReadOnlySpan<char> src, out ArgPrefix dst)
        {
            var kSrc = (uint)src.Length;
            var kTest = Prefixes.Count;
            for(var i=0; i<kTest; i++)
            {
                var test = memory.chars(Prefixes[i]);
                if(test.Length == 1 && kSrc >= 1)
                {
                    ref readonly var c0 = ref skip(src, 0);
                    ref readonly var t0 = ref skip(test, 0);
                    if(t0 == c0)
                    {
                        dst = new ArgPrefix((AsciCharCode)c0);
                        return true;
                    }
                }
                else if(test.Length == 2 && kSrc >= 2)
                {
                    ref readonly var c0 = ref skip(src, 0);
                    ref readonly var t0 = ref skip(test, 0);
                    if(c0 == t0)
                    {
                        ref readonly var c1 = ref skip(src, 1);
                        ref readonly var t1 = ref skip(test, 1);
                        if(c1 == t1)
                        {
                            dst = new ArgPrefix((AsciCharCode)c0, (AsciCharCode)c1);
                            return true;
                        }
                    }
                }
            }
            dst = ArgPrefix.Empty;
            return false;
        }
    }
}
