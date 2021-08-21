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

    using static Msg;

    public class AsmFormPipe : RecordPipe<AsmFormPipe,AsmFormRecord>
    {
        public AsmFormPipe()
        {

        }

        public void HashFormIndex()
        {

        }

        public ReadOnlySpan<AsmFormExpr> LoadFormExpressions()
        {
            var catalog = Wf.StanfordCatalog();
            catalog.EmitForms(catalog.DeriveFormExprssions());

            var src = Db.AsmCatalogTable<AsmFormRecord>();
            var records = Load(src);
            var count = records.Length;
            var buffer = alloc<AsmFormExpr>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst, i) = skip(records,i).FormExpr;
            return buffer;
        }

        public ReadOnlySpan<AsmFormHash> EmitFormHashes()
        {
            var pipe = Wf.AsmFormPipe();
            var expressions = pipe.LoadFormExpressions();
            var count = expressions.Length;
            var unique = dict<string,AsmFormExpr>();
            var duplicates = dict<string,AsmFormExpr>();
            for(var i=0; i<count; i++)
            {
                ref readonly var e = ref skip(expressions, i);
                if(e.IsEmpty)
                    continue;

                var format = e.Format();
                if(!unique.TryAdd(format,e))
                    duplicates[format] = e;

            }

            iter(duplicates.Keys, k => Wf.Warn(string.Format("Duplicate Form: {0}", k)));
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

        ReadOnlySpan<AsmFormHash> HashPerfect(ReadOnlySpan<AsmFormExpr> src)
        {
            Wf.Status($"Attempting to find perfect hashes for {src.Length} expressions");
            var perfect = HashFunctions.perfect(src, x => x.Format(), HashFunctions.strings()).Codes;
            var count = (uint)perfect.Length;

            Wf.Status($"Found {count} distinct hash codes for {src.Length} expressions");

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
            var ecount = Tables.emit(@readonly(buffer), dst);
            Wf.EmittedTable(emitting, ecount);
            return buffer;
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

        public ReadOnlySpan<AsmFormRecord> Load(in TextGrid src)
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
                    return array<AsmFormRecord>();
                }
                AsmParser.parse(row, ref seek(dst,i));
            }
            return buffer;
        }

        public ReadOnlySpan<AsmFormRecord> Load(FS.FilePath src)
        {
            var dst = list<AsmFormRecord>();
            if(src.Exists)
            {
                var flow = Wf.Running($"Loading form records from {src.ToUri()}");
                var doc = TextGrids.parse(src);
                if(doc.Failed)
                {
                    Wf.Error(doc.Reason);
                    return array<AsmFormRecord>();
                }

                var forms = Load(doc.Value);
                Wf.Ran(flow, LoadedForms.Format(forms.Length, src));
                return forms;
            }
            else
            {
                Wf.Error($"The file <{src.ToUri()}> does not exist");
                return array<AsmFormRecord>();
            }
        }

        protected override Outcome ParseRow(TextLine src, out AsmFormRecord dst)
        {
            var parts = Cells(src.Content);
            var count = parts.Length;
            if(count == FieldCount)
            {
                var i = 0u;
                DataParser.parse(NextCell(parts, ref i), out dst.Seq);
                dst.OpCode = asm.ocexpr(NextCell(parts, ref i));
                AsmParser.sigxpr(NextCell(parts, ref i), out dst.Sig);
                dst.FormExpr = new AsmFormExpr(dst.OpCode, dst.Sig);
                return true;
            }
            else
            {
                dst = default;
                return (false, FieldCountMismatch.Format(TableId, count, FieldCount));
            }
        }
    }
}