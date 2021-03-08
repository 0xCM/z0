//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    public sealed class CilEmitter : WfService<CilEmitter, CilEmitter>
    {
        const string CilDataLine = "{0,-16} | {1, -80} | {2}";

        const string CilCodeHeader = "// {0,-16} {1}";

        const string CilCodeSep = "// " + RP.PageBreak120;


        public void EmitCilCode(Index<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = src.Count;
            var visualizer = Cil.visualizer();
            var builder = text.build();
            if(count != 0)
            {
                var flow = Wf.EmittingFile(dst);
                var view = src.View;
                using var writer = dst.Writer();
                for(var i=0u; i<count; i++)
                {
                    var cil = skip(view,i).Member.Cil;
                    writer.WriteLine(CilCodeSep);
                    writer.WriteLine(string.Format(CilCodeHeader, cil.Base, cil.Id));
                    builder.Clear();
                    visualizer.DumpILBlock(cil.Encoded, cil.Encoded.Length, builder);
                    writer.WriteLine("{");
                    writer.WriteLine(builder.ToString());
                    writer.WriteLine("}");
                    writer.WriteLine();
                }

                Wf.EmittedFile(flow, count);
            }
        }

        public void EmitCilData(Index<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = src.Count;
            if(count != 0)
            {
                var flow = Wf.EmittingFile(dst);
                var view = src.View;
                using var writer = dst.Writer();
                for(var i=0u; i<count; i++)
                {
                    var cil = skip(view,i).Member.Cil;
                    var data = string.Format(CilDataLine, cil.Base, cil.Id, cil.Encoded.Format());
                    writer.WriteLine(cil.Format());
                }

                Wf.EmittedFile(flow, count);
            }
        }
    }
}