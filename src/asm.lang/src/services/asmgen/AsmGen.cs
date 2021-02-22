//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [ApiHost]
    public sealed partial class AsmGen : WfService<AsmGen,AsmGen>
    {
        [Op]
        public void GenerateModels(Index<AsmMnemonic> src)
        {
            var flow = Wf.Running();
            EmitInstructionContracts();
            EmitMonicExpressions(src);
            EmitMonicEnum(src);
            EmitInstructionTypes(src);
            Wf.Ran(flow);
        }

        const byte Indent = 4;

        const string Open = "{";

        const string Close = "}";
    }
}