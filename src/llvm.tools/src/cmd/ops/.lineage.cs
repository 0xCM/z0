//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using records;

    using static Root;
    using static core;
    using static Equivalence;

    partial class LlvmCmd
    {
        static ReadOnlySpan<ClassMember> heritage(ReadOnlySpan<ClassRelations> src)
        {
            var count = (uint)src.Length;
            var classes = Equivalence.lookup();
            var ancestors = dict<Class,string>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var relation = ref skip(src,i);
                var @class = new Class(i, relation.Name);

                if(!classes.Include(@class))
                    continue;

                if(relation.HasAncestor)
                    ancestors[@class] = relation.Ancestors.Name;
            }

            var members = list<ClassMember>();
            var indexed = classes.Seal();
            for(var i=0u; i<indexed.Length; i++)
            {
                ref readonly var child = ref skip(indexed,i);
                if(ancestors.TryGetValue(child, out var a))
                {
                    if(classes.Find(a, out var parent))
                        members.Add(new ClassMember(parent, child.ClassId, child.ClassName));
                }
            }

            return members.ViewDeposited();
        }

        [CmdOp(".lineage")]
        Outcome SummarizeLineage(CmdArgs args)
        {
            var result = Outcome.Success;
            var defs = Db.LoadDefRelations();
            var classes = Db.LoadClassRelations();

            var dst = Data.Log("lineage");
            var emitting = EmittingFile(dst);
            using var writer = dst.AsciWriter();

            iter(classes, r => {
                if(r.Ancestors.IsNonEmpty)
                    writer.WriteLine(string.Format("{0} -> {1}", r.Name, r.Ancestors));
                else
                    writer.WriteLine(r.Name);
            });

            iter(defs, r => {
                if(r.Ancestors.IsNonEmpty)
                    writer.WriteLine(string.Format("{0} -> {1}", r.Name, r.Ancestors));
                else
                    writer.WriteLine(r.Name);
            });

            iter(heritage(classes), c => Write(c.Format()));

            EmittedFile(emitting, classes.Length + defs.Length);

            return result;
        }
    }
}