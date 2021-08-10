//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct BitfieldGenerator
    {

    }

    partial class AsmCmdService
    {
        [Op]
        public static uint bitfield_3x3x2(Span<char> dst)
        {
            var f0 = BitSeq.bits(n3);
            var f1 = BitSeq.bits(n3);
            var f2 = BitSeq.bits(n2);
            var m=0u;
            for(var k=0; k<f2.Length; k++)
            {
                for(var j=0; j<f1.Length; j++)
                {
                    for(var i=0; i<f0.Length; i++)
                    {
                        var b0 = skip(f0, i);
                        var b1 = skip(f1, j);
                        var b2 = skip(f2, k);
                        var bits = BitNumbers.join(b0,b1,b2);
                        BitRender.render8(bits, ref m, dst);
                        seek(dst,m++) = (char)AsciControlSym.CR;
                        seek(dst,m++) = (char)AsciControlSym.LF;
                    }
                }
            }
            return m;
        }

        [CmdOp(".gen-bits")]
        Outcome GenBits(CmdArgs args)
        {
            var result = Outcome.Success;
            var path = Gen().Path("bitfields", "sib", FS.ext("bits"));
            var flow = Wf.EmittingFile(path);
            using var writer = path.AsciWriter();
            var dst = span<char>(256*128);
            var count = bitfield_3x3x2(dst);
            var rendered = slice(dst,0,count);
            writer.Write(rendered);
            Wf.EmittedFile(flow,count);
            return result;
        }
    }
}