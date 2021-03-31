//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using T = AsmGenTarget;

    [ApiHost]
    public sealed partial class AsmGen : WfService<AsmGen>
    {
        [Op]
        public void GenerateModelsInPlace(Index<AsmMnemonic> src)
        {
            var flow = Wf.Running();
            EmitInstructionContracts(GetTargetPath(T.InstructionContracts));
            EmitMonicExpressions(src, GetTargetPath(AsmGenTarget.MonicExpression));
            EmitMonicEnum(src, GetTargetPath(AsmGenTarget.MonicCodeEnum));
            EmitInstructionTypes(src,GetTargetPath(T.InstructionTypes));
            EmitStatementBuilder(src, GetTargetPath(T.StatementBuilder));
            Wf.Ran(flow);
        }

        [Op]
        public void GenerateModelsInPlace()
        {
            GenerateModelsInPlace(Wf.AsmCatalogEtl().Mnemonics());
        }

        [Op]
        public void GenerateModels(Index<AsmMnemonic> src, FS.FolderPath dst)
        {
            var flow = Wf.Running();
            EmitInstructionContracts(GetTargetPath(T.InstructionContracts, dst));
            EmitMonicExpressions(src, GetTargetPath(AsmGenTarget.MonicExpression, dst));
            EmitMonicEnum(src, GetTargetPath(AsmGenTarget.MonicCodeEnum, dst));
            EmitInstructionTypes(src, GetTargetPath(T.InstructionTypes, dst));
            EmitStatementBuilder(src, GetTargetPath(T.StatementBuilder, dst));
            Wf.Ran(flow);

        }

        [Op]
        public void GenerateModels(FS.FolderPath dst)
        {
            GenerateModels(Wf.AsmCatalogEtl().Mnemonics(),dst);
        }

        const byte Indent = 4;

        const string Open = "{";

        const string Close = "}";
    }
}