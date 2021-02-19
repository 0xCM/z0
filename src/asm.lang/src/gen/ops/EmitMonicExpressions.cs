//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmGen
    {
        void EmitMonicExpressions(Index<AsmMnemonic> src)
        {
            var dst = GetTargetPath(AsmGenTarget.MonicExpression);
            var flow = Wf.EmittingFile(dst);
            EmitMonicExpressions(src,dst);
            Wf.EmittedFile(flow,src.Count, dst);
        }

        void EmitMonicExpressions(Index<AsmMnemonic> src, FS.FilePath dst)
        {
            var buffer = text.buffer();
            var margin = 0u;
            MonicExpressionModel model = src.Storage;
            model.Render(margin,buffer);
            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());
        }
    }
}