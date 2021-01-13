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
        public ref FS.FilePath Emit(ApiHostUri uri, in ApiMemberCodeBlocks src, out FS.FilePath dst)
        {
            var path = Wf.Db().CapturedCilDataFile(uri);
            dst = FS.FilePath.Empty;
            if(src.Count != 0)
            {
                dst = path;
                var count = src.Count;
                var view = src.View;
                using var writer = path.Writer();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var parsed = ref skip(view,i);
                    var cil = ClrDynamic.cil(parsed.Address, parsed.OpUri, parsed.Method);
                    writer.WriteLine(cil.Format());
                }

                Wf.EmittedFile(src, count, dst);
            }

            return ref dst;
        }

        public ref FS.FilePath EmitDecoded(ApiHostUri uri, in ApiMemberCodeBlocks src, out FS.FilePath dst)
        {
            dst = Wf.Db().CapturedAsmFile(uri).ChangeExtension(FileExtensions.Il);
            if(src.Count != 0)
            {
                var module = src.First.Method.DeclaringType.Assembly.ManifestModule;
                var count = src.Count;
                var methods = src.Storage.Map(x => new LocatedMethod(x.OpUri.OpId, x.Method, x.Address));
                var cilFx = Cil.functions(module, methods).View;
                using var writer = dst.Writer();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var fx = ref skip(cilFx,i);
                    if(fx.IsNonEmpty)
                        writer.WriteLine(fx.Formatted);
                    else
                        writer.WriteLine("!!Empty!!");
                }

                Wf.EmittedFile(src, count, dst);
            }
            return ref dst;
        }
    }
}