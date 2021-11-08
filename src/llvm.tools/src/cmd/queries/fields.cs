//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static LlvmNames;
    using static core;

    using records;

    partial class LlvmCmd
    {
        [CmdOp(Queries.fields)]
        Outcome Fields(CmdArgs args)
        {
            var result = Outcome.Success;
            if(args.Length == 1)
            {
                var fields = Db.SelectFields(arg(args,0).Value);
                iter(fields, f => Write(f.Format()));
            }
            else if(args.Length == 2)
            {
                DataParser.parse(arg(args,0).Value, out uint offset);
                DataParser.parse(arg(args,1).Value, out uint length);
                var fields = Db.Fields(offset,length);
                iter(fields, f => Write(f.Format()));
            }
            else
            {
                var entities = list<Entity>();
                Db.QueryFields(provider => {
                    Write(provider.EntityName);
                });
            }
            return result;
        }
    }
}