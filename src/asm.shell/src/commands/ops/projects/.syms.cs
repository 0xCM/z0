//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using llvm;

    partial class AsmCmdService
    {
        [CmdOp(".syms")]
        Outcome Syms(CmdArgs args)
        {
            var result = Outcome.Success;
            var match = arg(args,0).Value;
            var files = ProjectOut().Files(FS.Sym,true);
            var formatter = Tables.formatter<ObjSymRecord>(ObjSymRecord.RenderWidths);
            var counter = 0u;
            foreach(var f in files)
            {
                if(f.Format().Contains(match))
                {
                    var records = LlvmNm.Read(f);
                    var count= records.Length;
                    for(var i=0; i<count; i++)
                    {
                        Write(formatter.Format(skip(records,i)));
                        counter++;
                    }
                }
            }
            Write(string.Format("Found {0} symbols", counter));
            return result;
        }
    }
}