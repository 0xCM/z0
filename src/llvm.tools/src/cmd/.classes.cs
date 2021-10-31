//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;
    partial class LlvmCmd
    {
        [CmdOp(".classes")]
        Outcome Classes(CmdArgs args)
        {
            var result = Outcome.Success;
            Db.Classes();
            return result;
        }

        [CmdOp(".defs")]
        Outcome Defs(CmdArgs args)
        {
            var result = Outcome.Success;
            Db.Defs();
            return result;
        }

        [CmdOp(".def")]
        Outcome Def(CmdArgs args)
        {
            var result = Outcome.Success;
            Db.Def(arg(args,0).Value);
            return result;
        }

        [CmdOp(".fields")]
        Outcome Fields(CmdArgs args)
        {
            var result = Outcome.Success;
            DataParser.parse(arg(args,0).Value, out uint offset);
            DataParser.parse(arg(args,1).Value, out uint length);

            var fields = Db.Fields(offset,length);
            for(var i=0; i < fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var dt = LlvmDataType.parse(field.DataType);
                if(dt.IsBits)
                {
                    dt.TypeArgs(out var bitarray);

                }


            }

            return result;
        }
    }
}