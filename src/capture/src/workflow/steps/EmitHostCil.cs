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
        FS.FilePath Target;

        ApiHostUri Uri;

        public static EmitHostCil create(FS.FilePath dst)
        {
            var host = new EmitHostCil();
            host.Target = dst;
            return host;
        }

        public static EmitHostCil create(ApiHostUri uri)
        {
            var host = new EmitHostCil();
            host.Uri = uri;
            return host;
        }

        protected override ref FS.FilePath Execute(IWfShell wf, in ApiMemberCodeBlocks src, out FS.FilePath dst)
        {

            var path = wf.Db().Document(Uri, "capture", "cil", FileKind.Cil, FileKind.Hex);
            if(src.Count != 0)
            {
                dst = path;
                wf = wf.WithHost(this);
                var count = src.Count;
                var view = src.View;
                using var writer = dst.Writer();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var parsed = ref skip(view,i);
                    var cil = ApiDynamic.cil(parsed.Address, parsed.OpUri, parsed.Method);
                    writer.WriteLine(cil.Format());
                }

                wf.EmittedFile(src, count, dst);
            }

            return ref dst;
        }
    }
}