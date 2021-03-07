//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmExpr;

    public sealed class AsmFormPipe : WfService<AsmFormPipe>
    {
        public void Emit(ReadOnlySpan<Form> src, FS.FilePath dst)
        {
            var count = src.Length;
            if(count == 0)
            {
                Wf.Warn("No work to do");
                return;
            }

            var flow = Wf.EmittingTable<AsmFormRecord>(dst);
            var formatter = Records.formatter<AsmFormRecord>(32);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(ushort i=0; i<count; i++)
                writer.WriteLine(formatter.Format(record(i, skip(src,i))));
            Wf.EmittedTable(flow, count);
        }

        [MethodImpl(Inline), Op]
        static AsmFormRecord record(ushort seq, Form src)
        {
            var dst = new AsmFormRecord();
            dst.Seq = seq;
            dst.OpCode = src.OpCode;
            dst.Sig = src.Sig;
            dst.Expression = src.Expression;
            return dst;
        }
    }
}