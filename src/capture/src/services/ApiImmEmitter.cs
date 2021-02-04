//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static memory;

    public sealed class ApiImmEmitter : AsmWfService<ApiImmEmitter>
    {
        ICaptureCore Capture;

        IImmSpecializer Specializer;

        IDynexus Dynamic;

        bool Append = true;

        protected override void OnInit()
        {
            base.OnInit();
            Capture = CaptureCore.Service;
            Specializer = CaptureServices.Service.ImmSpecializer(Decoder);
            Dynamic = Dynops.Dynexus;
        }

        AsmImmWriter HostArchiver(ApiHostUri host, IAsmFormatter formatter, FS.FolderPath dst)
            => new AsmImmWriter(host, formatter, dst);

        IApiHost[] Hosts(params PartId[] parts)
            => Wf.Api.ApiHosts;

        IAsmImmWriter Archive(IApiHost host)
            => Services.ImmWriter(host.Uri);

        SpecializedImmEvent Specialized(ApiHostUri uri, bool generic, FS.FilePath path, Type refinement)
            => default(SpecializedImmEvent).define(Host, uri, generic, path, refinement, Wf.Ct);

        void EmitUnary(in CaptureExchange exchange, ApiMethodG src, Imm8R[] imm8, IAsmImmWriter dst, Type refinement = null)
        {
            var gid = src.Id;
            var uri = src.Host.Uri;
            var generic = true;

            var closures = Identity.Closures(src).Index().View;
            var count = closures.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var closure = ref skip(closures,i);
                var routines = UnaryOps(exchange, closure.Method, closure.Id, imm8);
                if(routines.Length != 0)
                {
                    var hex = dst.SaveHexImm(gid, routines, Append);
                    if(hex)
                        Wf.Raise(Specialized(uri, generic, hex.Value, refinement));
                    else
                        Wf.Error(Msg.IoError.Format(src.Id));

                    var asm = dst.SaveAsmImm(gid, routines, Append);
                    if(asm)
                        Wf.Raise(Specialized(uri, generic, asm.Value, refinement));
                    else
                        Wf.Error(Msg.IoError.Format(src.Id));
                }
            }
        }

        AsmRoutine[] UnaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, ReadOnlySpan<Imm8R> imm)
        {
            var count = imm.Length;
            var buffer = alloc<AsmRoutine>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref var current = ref seek(dst,i);
                var routine = UnaryOp(exchange,src, id, skip(imm,i));
                if(routine)
                    current = routine.Value;
                else
                {
                    current = AsmRoutine.Empty;
                    Wf.Error(Msg.CaptureFailed.Format(id));
                }
            }
            return buffer;
        }

        Option<AsmRoutine> UnaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm)
        {
            var width = VK.width(src.ReturnType);
            var f = Dynamic.CreateUnaryOp(width, src, imm);
            if(f)
              return
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.Decode(c)
                    select d;
            else
            {
                Wf.Error(Msg.DynamicMethodFailure.Format(id));
                return root.none<AsmRoutine>();
            }
        }
    }

    [ApiDeep]
    public readonly partial struct Msg
    {
        public static RenderPattern<OpIdentity> IoError => "I/O error during emission of {0} immediate closures";

        public static RenderPattern<OpIdentity> CaptureFailed => "{0} capture failed";

        public static RenderPattern<OpIdentity> DynamicMethodFailure => "{0} dynamic method creation failure";
    }
}