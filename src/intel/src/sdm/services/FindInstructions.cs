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


    partial class IntelSdmProcessor
    {

        public ReadOnlySpan<TextLine> FindInstructions()
        {
            ReadOnlySpan<string> P1 = new string[]{"Opcode","Instruction","Op/","En","64-bit", "Mode", "Compat/", "Leg Mode", "Description"};
            ReadOnlySpan<string> P2 = new string[]{"Opcode/","Instruction","Op/","En","64/32-bit", "Mode", "CPUID", "Feature", "Flag", "Description"};

            var dst = list<TextLine>();
            var headers = list<TextLine>();
            var src = LinedSdmPath();
            var log = ProcessLog("instructions");
            using var reader = src.LineReader();
            using var logger = log.Writer();
            var i=0;
            while(reader.Next(out var line))
            {
                i = FindHeader(P1,reader, ref line, headers);
                if(i == P1.Length)
                    iter(headers, h => logger.WriteLine(h));
                if(i != 0)
                    headers.Clear();

            }

            return dst.ViewDeposited();
        }

        static int FindHeader(ReadOnlySpan<string> pattern, in LineReader reader, ref TextLine line, List<TextLine> headers)
        {
            var i=0;
            while(i < pattern.Length && line.Content.StartsWith(skip(pattern,i++)))
            {
                headers.Add(line);
                if(!reader.Next(out line))
                    break;
            }
            return i;
        }
    }
}