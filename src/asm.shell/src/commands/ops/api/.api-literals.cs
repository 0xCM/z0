//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".api-literals")]
        Outcome EmitApiLiterals(CmdArgs args)
        {
            var result = Outcome.Success;
            var literals = State.ApiLiterals(Loaders.ApiLiterals);
            var path = Emitters.Emit(literals, Ws.Tables().Subdir(machine));
            return result;
        }
   }
}