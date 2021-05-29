//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsmRecords;

    public class AsmFormPipe : RecordPipe<AsmFormPipe,AsmFormRecord>
    {
        public AsmFormPipe()
            : base(42)
        {

        }

        public void HashFormIndex()
        {

        }

        public Index<AsmFormExpr> LoadFormExpressions()
        {
            var catalog = Wf.StanfordCatalog();
            catalog.Emit(catalog.KnownFormExpressions());

            var pipe = AsmFormPipe.create(Wf);
            var src = Db.AsmCatalogTable<AsmFormRecord>();
            var records = pipe.Load(src).View;

            var count = records.Length;
            var expressions = alloc<AsmFormExpr>(count);
            ref var block = ref first(expressions);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                seek(block, i) = record.FormExpr;
            }
            return expressions;
        }

        Index<AsmFormHash> HashPerfect(Span<AsmFormExpr> src)
        {
            Wf.Status($"Attempting to find perfect hashes for {src.Length} form expressions");
            var perfect = HashFunctions.perfect(src, x => x.Format(), HashFunctions.strings()).Codes;
            var count = (uint)perfect.Length;

            Wf.Status($"Found {count} distinct hash codes for {src.Length} form expressions");

            var dst = Db.AsmCatalogTable<AsmFormHash>();
            var buffer = alloc<AsmFormHash>(count);
            ref var records = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref var record = ref seek(records,i);
                ref readonly var hash = ref skip(perfect,i);
                record.Form = hash.Source;
                record.HashCode = hash.Hash;
                record.IndexKey = (hash.Hash % count);
            }
            var emitting = Wf.EmittingTable<AsmFormHash>(dst);
            var ecount = Tables.emit(buffer, dst, 36);
            Wf.EmittedTable(emitting, ecount);
            return buffer;
        }

        public Index<AsmFormHash> EmitFormHashes()
        {
            var pipe = Wf.AsmFormPipe();
            var expressions = pipe.LoadFormExpressions();
            var unique = root.dict<string,AsmFormExpr>();
            var duplicates = root.dict<string,AsmFormExpr>();
            foreach(var e in expressions)
            {
                if(e.IsEmpty)
                    continue;

                var format = e.Format();
                if(!unique.TryAdd(format,e))
                    duplicates[format] = e;
            }

            root.iter(duplicates.Keys, k => Wf.Warn(string.Format("Duplicate Form: {0}", k)));
            return HashPerfect(unique.Values.Array());
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
            dst.FormExpr = src;
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
                var flow = Wf.Running($"Loading form records from {src.ToUri()}");
                var doc = TextDocs.parse(src);
                if(doc.Failed)
                {
                    Wf.Error(doc.Reason);
                    return sys.empty<AsmFormRecord>();
                }

                var forms = Load(doc.Value);
                Wf.Ran(flow, string.Format("Loaded {0} forms from {1}", forms.Length, src.ToUri()));
                return forms;
            }
            else
            {
                Wf.Error($"The file <{src.ToUri()}> does not exist");
                return sys.empty<AsmFormRecord>();
            }
        }

        protected override Outcome ParseRow(string src, out AsmFormRecord dst)
        {
            var parts = Cells(src);
            var count = parts.Length;
            if(count == FieldCount)
            {
                var i = 0u;
                DataParser.parse(NextCell(parts, ref i), out dst.Seq);
                dst.OpCode = AsmCore.opcode(NextCell(parts, ref i));
                AsmParser.sig(NextCell(parts, ref i), out dst.Sig);
                dst.FormExpr = new AsmFormExpr(dst.OpCode, dst.Sig);
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
            DataParser.parse(src[i++], out dst.Seq);
            AsmParser.opcode(src[i++], out dst.OpCode);
            AsmParser.sig(src[i++], out dst.Sig);
            AsmParser.form(src[i++], out dst.FormExpr);
            return ref dst;
        }
    }
}