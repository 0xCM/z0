//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static z;

    public class t_legal_identity : t_asm<t_legal_identity>
    {
        public void check_code_identity()
        {
            var catalog = ApiCatalogs.part(Parts.Math.Resolved);
            var ops = @readonly(catalog.Operations);
            var count = ops.Length;
            var path = Paths.CasePath();
            Trace(path);
            using var dst = path.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var f = ref skip(ops,i);
                var name = f.Name;
                var opid = f.Identify();
                var legal = ApiMemberIdentifier.create(opid);
                dst.WriteLine($"{name} | {opid.Identifier} {legal}");
            }
        }
    }
}