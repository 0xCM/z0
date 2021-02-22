//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    partial class AsmGen
    {
        void EmitMonicEnum(Index<AsmMnemonic> src)
        {
            var dst = GetTargetPath(AsmGenTarget.MonicCode);
            var flow = Wf.EmittingFile(dst);
            EmitMonicEnum(src,dst);
            Wf.EmittedFile(flow,src.Count, dst);
        }

        void EmitMonicEnum(Index<AsmMnemonic> src, FS.FilePath dst)
        {
            var buffer = text.buffer();
            var margin = 0u;
            MonicEnumModel model = src.Storage;
            model.Render(margin, buffer);
            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());
        }
    }
}