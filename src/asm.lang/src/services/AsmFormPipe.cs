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

    public class AsmFormPipe : RecordPipe<AsmFormPipe,AsmFormRecord>
    {
        public AsmFormPipe()
            : base(42)
        {

        }

        AsmSigs Sigs;

        protected override void OnInit()
        {
            Sigs = Wf.AsmSigs();
        }

        public void Emit(ReadOnlySpan<AsmFormExpr> src, FS.FilePath dst)
        {
            var count = src.Length;
            if(count == 0)
            {
                Wf.Warn("No work to do");
                return;
            }

            var flow = Wf.EmittingTable<AsmFormRecord>(dst);
            using var writer = dst.Writer();
            writer.WriteLine(FormatHeader());
            for(ushort i=0; i<count; i++)
            {
                var data = NewRecord();
                writer.WriteLine(Format(Fill(i, skip(src,i), ref data)));
            }
            Wf.EmittedTable(flow, count);
        }

        [MethodImpl(Inline)]
        ref AsmFormRecord Fill(ushort seq, AsmFormExpr src, ref AsmFormRecord dst)
        {
            dst.Seq = seq;
            dst.OpCode = src.OpCode;
            dst.Sig = src.Sig;
            dst.Expression = src.Expression;
            return ref dst;
        }

        public Index<AsmFormRecord> Load(in TextDoc src)
        {
            var rows = src.Rows;
            var count = rows.Length;
            var buffer = alloc<AsmFormRecord>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                if(i==0)
                    continue;

                ref readonly var row = ref skip(rows,i);
                if(row.CellCount != FieldCount)
                {
                    Wf.Error(FieldCountMismatch.Format(TableId, row.CellCount, FieldCount));
                    return sys.empty<AsmFormRecord>();
                }
                Parse(row, ref seek(dst,i));
            }
            return buffer;
        }

        public Index<AsmFormRecord> Load(FS.FilePath src)
        {
            var dst = root.list<AsmFormRecord>();
            if(src.Exists)
            {
                var doc = TextDocs.parse(src);
                if(doc.Failed)
                {
                    Wf.Error(doc.Reason);
                    return sys.empty<AsmFormRecord>();
                }

                return Load(doc.Value);
            }
            else
            {
                Wf.Error($"The file <{src.ToUri()}> does not exist");
                return sys.empty<AsmFormRecord>();
            }
        }

        public Outcome Parse(string src, out AsmFormRecord dst)
        {
            var parts = Cells(src);
            var count = parts.Length;
            if(count == FieldCount)
            {
                var i = 0u;
                Records.parse(NextCell(parts, ref i), out dst.Seq);
                dst.OpCode = asm.opcode(NextCell(parts, ref i));
                Sigs.ParseSigExpr(NextCell(parts, ref i), out dst.Sig);
                dst.Expression = NextCell(parts, ref i);
                return true;
            }
            else
            {
                dst = default;
                return (false, FieldCountMismatch.Format(TableId, count, FieldCount));
            }
        }

        public ref AsmFormRecord Parse(TextRow src, ref AsmFormRecord dst)
        {
            var i = 0;
            Records.parse(src[i++], out dst.Seq);
            dst.OpCode = asm.opcode(src[i++]);
            Sigs.ParseSigExpr(src[i++], out dst.Sig);
            dst.Expression = src[i++];
            return ref dst;
        }
    }
}