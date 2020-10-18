//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    [WfHost]
    public sealed class EmitHostCil : WfHost<EmitHostCil, ApiMemberCodeBlocks, FS.FilePath>
    {
        ApiHostUri Uri;

        public static EmitHostCil create(ApiHostUri uri)
        {
            var host = new EmitHostCil();
            host.Uri = uri;
            return host;
        }

        protected override ref FS.FilePath Execute(IWfShell wf, in ApiMemberCodeBlocks src, out FS.FilePath dst)
        {
            var path = wf.Db().CapturedCilFile(Uri);
            if(src.Count != 0)
            {
                dst = path;
                wf = wf.WithHost(this);
                var count = src.Count;
                var view = src.View;
                using var writer = path.Writer();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var parsed = ref skip(view,i);

                    var cil = ApiDynamic.cil(parsed.Address, parsed.OpUri, parsed.Method);
                    writer.WriteLine(cil.Format());
                }

                wf.EmittedFile(src, count, dst);
            }

            EmitDecoded(wf, src, out var _);

            return ref dst;
        }

        ref FS.FilePath EmitDecoded(IWfShell wf, in ApiMemberCodeBlocks src, out FS.FilePath dst)
        {
            dst = wf.Db().CapturedAsmFile(Uri).ChangeExtension(ArchiveFileKinds.Il);
            if(src.Count != 0)
            {
                wf = wf.WithHost(this);
                var module = src.First.Method.DeclaringType.Assembly.ManifestModule;
                var count = src.Count;
                var methods = src.Storage.Map(x => new LocatedMethod(x.OpUri.OpId, x.Method, x.Address));
                var cilFx = @readonly(CilApi.functions(module, methods));
                using var writer = dst.Writer();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var fx = ref skip(cilFx,i);
                    if(fx.IsNonEmpty)
                        writer.WriteLine(fx.Formatted);
                    else
                        writer.WriteLine("!!Empty!!");
                }

                wf.EmittedFile(src, count, dst);
            }
            return ref dst;
        }
    }
}