//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    partial struct asm
    {
        public static uint lines(FS.FilePath src, List<AsmLine> dst)
        {
            var counter = 0u;
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if(AsmParser.parse(line, out AsmBlockLabel label, out AsmExpr expr))
                {
                    if(AsmParser.parse(label, out AsmOffsetLabel offset))
                    {
                        dst.Add(asm.line(offset, expr));
                        counter++;
                    }
                    else
                    {
                        if(expr.IsNonEmpty)
                        {
                            dst.Add(asm.line(label, expr));
                            counter++;
                        }
                        else
                        {
                            dst.Add(asm.line(label));
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }
    }
}