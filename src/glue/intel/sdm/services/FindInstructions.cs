//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public readonly struct LinePattern
    {
        readonly Index<string> Data;

        [MethodImpl(Inline)]
        public LinePattern(string[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator LinePattern(string[] src)
            => new LinePattern(src);
    }

    partial class IntelSdmProcessor
    {
        static LinePattern HP0() => new string[]{"Opcode","Instruction", "Op/", "En", "64-bit", "Mode", "Compat/", "Leg Mode", "Description"};

        static ReadOnlySpan<string> HP1() => new string[]{"Opcode/","Instruction", "Op/", "En", "64/32 bit", "Mode", "Support", "CPUID", "Feature Flag", "Description"};

        static ReadOnlySpan<string> HP2() => new string[]{"Opcode/Instruction","Op/", "En"};

        static ReadOnlySpan<string> HP3() => new string[]{"Opcode/","Instruction", "Op /", "En", "64/32 bit", "Mode", "Support"};

        public ReadOnlySpan<TextLine> ReadLinedSdm()
        {
            var dst = list<TextLine>();
            var src = LinedSdmPath();
            using var reader = src.LineReader();
            while(reader.Next(out var line))
                dst.Add(line);
            return dst.ViewDeposited();
        }

        public SortedSpan<TextLine> FindInstructions()
        {
            var dst = bag<TextLine>();
            var log = ProcessLog("instructions");
            var lines = ReadLinedSdm();
            var count = lines.Length;
            using var logger = log.Writer();
            var pm0 = MatchPattern(lines,HP0());
            iter(pm0, x => dst.Add(x));
            // var pm1 = MatchPattern(lines,HP1());
            // iter(pm1, x => dst.Add(x));
            // var pm2 = MatchPattern(lines,HP2());
            // iter(pm2, x => dst.Add(x));
            // var pm3 = MatchPattern(lines,HP3());
            // iter(pm3, x => dst.Add(x));

            var result = dst.ToSortedSpan();
            iter(result, r => logger.WriteLine(r));

            return result;
        }

        static ReadOnlySpan<TextLine> MatchPattern(ReadOnlySpan<TextLine> src, LinePattern pattern)
        {
            var dst = list<TextLine>();
            var tmp = list<TextLine>();
            var count = src.Length;
            var parts = pattern.View;
            for(var i=0; i<count; i++)
            {
                for(var j=0; j<pattern.Length && i<count; j++)
                {
                    ref readonly var line = ref skip(src,i++);
                    if(line.Content.StartsWith(skip(parts,j)))
                        tmp.Add(line);
                    else
                    {
                        tmp.Clear();
                        break;
                    }
                }

                if(tmp.Count == pattern.Length)
                    dst.AddRange(tmp);

            }
            return dst.ViewDeposited();
        }
    }
}