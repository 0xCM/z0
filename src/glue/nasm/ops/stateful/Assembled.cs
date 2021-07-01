//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using Z0.Asm;

    using static core;

    partial class Nasm
    {
        public ref AsmAssembly Assembled(in NasmEncoding src, out AsmAssembly dst)
        {
            dst.Bitstring = FormatBitstring(src.Encoded);
            dst.Encoding = src.Encoded;
            dst.Statement = asm.expr(src.SourceText);
            dst.SourceLine = src.LineNumber;
            dst.Offset = src.Offset;
            return ref dst;
        }

        public Index<AsmAssembly> Assembled(ReadOnlySpan<NasmCodeBlock> blocks)
        {
            var dst = list<AsmAssembly>();
            var count = blocks.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var code = block.Code.View;
                for(var j=0; j<code.Length; j++)
                    dst.Add(Assembled(skip(code,j), out var a));
            }
            return dst.ToArray();
        }
    }
}