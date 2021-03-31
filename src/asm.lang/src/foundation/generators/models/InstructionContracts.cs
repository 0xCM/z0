//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmGen
    {
        void EmitInstructionContracts(FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var buffer = text.buffer();
            RenderInstructionContracts(0,buffer);

            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());

            Wf.EmittedFile(flow,1);
        }

        void RenderInstructionContracts(uint margin, ITextBuffer dst)
        {
            var target = TargetIdentifier(AsmGenTarget.InstructionContracts);
            var content = InstructionContractPattern.Replace(text.embrace("TargetName"), target);
            dst.AppendLine(content);
        }

        const string InstructionContractPattern = @"namespace Z0.Asm
{
    public interface {TargetName}
    {
        AsmMnemonicCode Mnemonic {get;}
    }

    public interface {TargetName}<T> : {TargetName}
        where T : struct, {TargetName}<T>
    {

    }
}";

    }
}