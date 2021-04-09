//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    using Z0.Asm;

    using static memory;

    partial class Nasm
    {
        public ref AssembledAsm Assembled(in NasmEncoding src, out AssembledAsm dst)
        {
            dst.Bitstring = new AsmBitstring(FormatBitstring(src.Code));
            dst.Encoding = src.Code;
            dst.Expression = src.SourceText;
            dst.SourceLine = src.LineNumber;
            dst.Offset = src.Offset;
            return ref dst;
        }

        public Index<AssembledAsm> Assembled(ReadOnlySpan<NasmCodeBlock> blocks)
        {
            var dst = root.list<AssembledAsm>();
            var count = blocks.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var code = block.Code.View;
                for(var j=0; j<code.Length; j++)
                {
                    dst.Add(Assembled(skip(code,j), out var a));
                }
            }
            return dst.ToArray();
        }
    }
}