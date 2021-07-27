//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".datasource", "Selects a data source from the 'sources' workspace")]
        public Outcome DataSource(CmdArgs args)
        {
            var scope = arg(args,0).Value;
            Write(State.DataSource(Ws.Sources().Subdir(scope)));
            return true;
        }
    }
}