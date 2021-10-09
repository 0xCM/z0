//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    using static core;

    using F = llvm.TableGenField;

    partial class EtlWorkflow
    {
        public static ReadOnlySpan<TableGenFields> partition(ReadOnlySpan<TableGenField> src)
        {
            var count = src.Length;
            var dst = list<TableGenFields>();
            var subset = list<TableGenField>();
            var current = Identifier.Empty;
            for(var i=0; i<count; i++)
            {
                ref readonly var f = ref skip(src,i);
                ref readonly var id = ref f.Id;
                if(id != current)
                {
                    if(subset.Count != 0)
                    {
                        dst.Add(new TableGenFields(current, subset.ToArray()));
                        subset.Clear();
                        current = id;
                    }
                }
                subset.Add(f);
            }

            if(subset.Count != 0)
                dst.Add(new TableGenFields(current, subset.ToArray()));
            return dst.ViewDeposited();
        }

        Outcome EmitFields(ReadOnlySpan<TableGenField> src, string dstid)
        {
            var fields = src;
            var parts = partition(fields);
            var count = fields.Length;
            var dst = LlvmPaths.ImportTable(dstid);
            var emitting = EmittingTable<TableGenField>(dst);
            using var writer = dst.AsciWriter();
            writer.WriteLine(F.RowHeader);
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                writer.WriteLine(string.Format(F.RowFormat, field.Id, field.DataType, field.Name, field.Value));
            }

            EmittedTable(emitting, count);
            return true;
        }
    }
}