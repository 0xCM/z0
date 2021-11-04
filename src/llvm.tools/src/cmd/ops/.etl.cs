//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static Root;
    using static core;
    using static Equivalence;
    using static ProjectScriptNames;

    partial class LlvmCmd
    {
        [CmdOp(".etl")]
        Outcome RunEtl(CmdArgs args)
        {
            var data = LlvmEtl.RunEtl();
            var relations = data.ClassRelations;
            var count = (uint)relations.Length;
            var classes = Equivalence.lookup();
            var ancestors = dict<Class,string>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var relation = ref skip(relations,i);
                ref readonly var heritage = ref relation.Ancestors;
                var @class = new Class(i, relation.Name);

                if(classes.Include(@class))
                {
                    Write(string.Format("Defined equivalence class {0}", @class));
                }
                else
                {
                    Error(string.Format("Duplicate class {0}", @class));
                    break;
                }

                if(relation.Ancestors.HasAncestor)
                {
                    ancestors[@class] = relation.Ancestors.Name;
                }
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

            iter(members, m => Write(m.Format()));

            return true;
        }
    }
}