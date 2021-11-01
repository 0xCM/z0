//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".classes")]
        Outcome Classes(CmdArgs args)
        {
            var result = Outcome.Success;
            var dst = LlvmPaths.TmpFile("classes", FS.Txt);
            using var writer = dst.AsciWriter();
            Db.Classes(writer);
            return result;
        }

        [CmdOp(".fields")]
        Outcome Fields(CmdArgs args)
        {
            var result = Outcome.Success;
            if(args.Length == 2)
            {
                DataParser.parse(arg(args,0).Value, out uint offset);
                DataParser.parse(arg(args,1).Value, out uint length);
                var fields = Db.Fields(offset,length);
                iter(fields, f => Write(f.Format()));
            }
            else
            {
                var types = hashset<string>();
                var defs = list<Identifier>();
                Db.Fields(provider => {
                    defs.Add(provider.EntityName);
                });

                iter(defs, d => Write(d));
            }
            return result;
        }
    }
}