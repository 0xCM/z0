//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using types;

    using static Root;
    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".etl")]
        Outcome RunEtl(CmdArgs args)
        {
            var data = LlvmEtl.RunEtl();
            var relations = data.ClassRelations;
            var count = (uint)relations.Length;
            var classes = new EqClassLookup();
            var ancestors = dict<EqClass,string>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var relation = ref skip(relations,i);
                ref readonly var heritage = ref relation.Ancestors;
                var @class = new EqClass(i, relation.Name);

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

            var members = list<EqClassMember>();
            var indexed = classes.Seal();
            for(var i=0u; i<indexed.Length; i++)
            {
                ref readonly var child = ref skip(indexed,i);
                if(ancestors.TryGetValue(child, out var a))
                {
                    if(classes.Find(a, out var parent))
                    {
                        members.Add(new EqClassMember(parent, child.ClassId, child.ClassName));
                    }
                }
            }

            iter(members, m => Write(m.Format()));

            return true;
        }
    }
}