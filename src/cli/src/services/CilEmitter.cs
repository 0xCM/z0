//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    [WfHost]
    public sealed class CilEmitter : WfService<CilEmitter, CilEmitter>
    {
        const string CilDataLine = "{0,-16} | {1, -80} | {2}";

        const string CilCodeHeader = "// {0,-16} {1}";

        const string CilCodeSep = "// " + RP.PageBreak120;

        public void EmitCilCode(Index<ApiMemberCode> src, FS.FilePath dst)
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
                    writer.WriteLine(CilCodeSep);
                    writer.WriteLine(string.Format(CilCodeHeader,cil.Base, cil.Id));
                    writer.WriteLine(cil.Formatted);
                }

                Wf.EmittedFile(flow, count, dst);
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

                Wf.EmittedFile(flow, count, dst);
            }
        }

        // public ref FS.FilePath EmitDecoded(ApiHostUri uri, in ApiMemberCodeBlocks src, out FS.FilePath dst)
        // {
        //     dst = Wf.Db().CapturedAsmFile(uri).ChangeExtension(FileExtensions.Il);
        //     if(src.Count != 0)
        //     {
        //         var module = src.First.Method.DeclaringType.Assembly.ManifestModule;
        //         var count = src.Count;
        //         var methods = src.Storage.Map(x => new LocatedMethod(x.OpUri.OpId, x.Method, x.Address));
        //         var cilFx = Cil.functions(module, methods).View;
        //         using var writer = dst.Writer();
        //         for(var i=0u; i<count; i++)
        //         {
        //             ref readonly var fx = ref skip(cilFx,i);
        //             if(fx.IsNonEmpty)
        //                 writer.WriteLine(fx.Formatted);
        //             else
        //                 writer.WriteLine("!!Empty!!");
        //         }

        //         Wf.EmittedFile(src, count, dst);
        //     }
        //     return ref dst;
        // }
    }
}