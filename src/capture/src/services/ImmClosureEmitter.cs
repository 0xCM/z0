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


    public class ImmClosureEmitter : IImmEmitter
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly IPartCapturePaths CodeArchive;

        readonly IImmSpecializer Specializer;

        readonly IAsmServices Services;

        public ImmClosureEmitter(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(typeof(ImmClosureEmitter));
            Wf = wf.WithHost(Host);
            Asm = asm;
            CodeArchive = Archives.capture(wf.Db().CaptureRoot());
            Specializer = Capture.Services.ImmSpecializer(asm.RoutineDecoder);
            Services = AsmServices.init(Wf,asm);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        bool Append = true;

        public void ClearArchive(params PartId[] parts)
        {
            if(parts.Length != 0)
                CodeArchive.ImmHostDirs(parts).Delete();
            else
                CodeArchive.ImmRoot.Delete();
        }

        public void EmitLiteral(byte[] imm8, params PartId[] parts)
        {
            if(imm8.Length != 0)
            {
                var exchange = Capture.exchange(Asm);
                EmitUnrefined(exchange, imm8.ToImm8Values(RefinementClass.Unrefined), parts);
            }
        }

        AsmImmWriter HostArchiver(ApiHostUri host, IAsmFormatter formatter, FS.FolderPath dst)
            => new AsmImmWriter(host, formatter, dst);

        public void EmitRefined(params PartId[] parts)
            => EmitRefined(Capture.exchange(Asm), parts);

        ParameterInfo RefiningParameter(MethodInfo src)
            => src.ImmParameters(RefinementClass.Refined).First();

        Type RefinementType(MethodInfo src)
            => src.ImmParameters(RefinementClass.Refined).First().ParameterType;

        Imm8R[] RefinedValues(MethodInfo src)
            => RefiningParameter(src).RefinedImmValues();

        void EmitDirectRefinements(in CaptureExchange exchange, ApiHost host, IAsmImmWriter dst)
        {
            var groups = ApiImmediates.direct(host,RefinementClass.Refined);
            var uri = host.Uri;
            var generic = false;
            foreach(var g in groups)
            {
                var gid = g.GroupId;
                foreach(var member in g.Members.Storage)
                {
                    if(member.Method.IsVectorizedUnaryImm(RefinementClass.Refined))
                    {
                        var imm8 = RefinedValues(member.Method);
                        if(imm8.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = Specializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                            if(functions.Length != 0)
                            {
                                dst.SaveHexImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(SpecializedImmEvent).refined(Host, uri, generic, rft, path, Wf.Ct)));
                                dst.SaveAsmImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(SpecializedImmEvent).refined(Host, uri, generic, rft, path, Wf.Ct)));
                            }
                        }
                    }
                    else if(member.Method.IsVectorizedBinaryImm(RefinementClass.Refined))
                    {
                        var values = RefinedValues(member.Method);
                        if(values.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = Specializer.BinaryOps(exchange, member.Method, member.Id, values);
                            if(functions.Length != 0)
                            {
                                dst.SaveHexImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(SpecializedImmEvent).refined(Host, uri, generic, rft, path, Wf.Ct)));
                                dst.SaveAsmImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(SpecializedImmEvent).refined(Host, uri, generic, rft, path, Wf.Ct)));
                            }
                        }
                    }
                }
            }
        }

        ApiHost[] Hosts(params PartId[] parts)
            => (from h in Wf.Api.PartHosts(parts)
                where h is ApiHost
                select (ApiHost)h).Array();

        IAsmImmWriter Archive(IApiHost host)
            => Services.ImmWriter(host.Uri);

        void EmitUnrefined(in CaptureExchange exchange, Imm8R[] imm8, params PartId[] parts)
        {
            EmitUnrefinedDirect(exchange, imm8, parts);
            EmitUnrefinedGeneric(exchange, imm8, parts);
        }

        void EmitRefined(in CaptureExchange exchange, params PartId[] parts)
        {
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host);
                EmitDirectRefinements(exchange, host, archive);
                EmitGenericRefinements(exchange, host, archive);
            }
        }

        void EmitUnrefinedDirect(in CaptureExchange exchange, Imm8R[] imm8, params PartId[] parts)
        {
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host);
                var groups = ApiImmediates.direct(host, RefinementClass.Unrefined);
                EmitUnrefinedDirect(exchange, groups,imm8, archive);
            }
        }

        void EmitUnrefinedDirect(in CaptureExchange exchange, DirectApiGroup[] groups, Imm8R[] imm8, IAsmImmWriter dst)
        {
            var unary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedUnaryImm(RefinementClass.Unrefined))
                        select (g,members.Array());

            foreach(var (g,members) in unary)
                EmitUnrefinedUnary(exchange, g.GroupId, members, imm8, dst);

            var binary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedBinaryImm(RefinementClass.Unrefined))
                        select (g,members.Array());

            foreach(var (g,members) in binary)
                EmitUnrefinedBinary(exchange, g.GroupId, members, imm8, dst);
        }

        void EmitUnrefinedGeneric(in CaptureExchange exchange, Imm8R[] imm8, params PartId[] parts)
        {
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host);
                var specs = ApiImmediates.generic(host, RefinementClass.Unrefined);
                foreach(var spec in specs)
                    EmitUnrefinedGeneric(exchange, spec, imm8, archive);
            }
        }

        void EmitGenericRefinements(in CaptureExchange exchange, ApiHost host, IAsmImmWriter dst)
        {
            var specs = ApiImmediates.generic(host, RefinementClass.Refined);
            foreach(var f in specs)
            {
                if(f.Method.IsVectorizedUnaryImm(RefinementClass.Refined))
                    EmitUnary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method));
                else if(f.Method.IsVectorizedBinaryImm(RefinementClass.Refined))
                    EmitBinary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method));
            }
        }

        void EmitUnrefinedGeneric(in CaptureExchange exchange, ApiMethodG src,  Imm8R[] imm8, IAsmImmWriter dst)
        {
            if(src.Method.IsVectorizedUnaryImm(RefinementClass.Unrefined))
                EmitUnary(exchange, src, imm8, dst);
            else if(src.Method.IsVectorizedBinaryImm(RefinementClass.Unrefined))
                EmitBinary(exchange, src, imm8, dst);
        }

        void EmitUnrefinedUnary(in CaptureExchange exchange, OpIdentity gid, DirectApiMethod[] methods, Imm8R[] imm8, IAsmImmWriter dst)
        {
            var generic = false;
            foreach(var f in methods)
            {
                var host = f.Host;
                var uri = host.Uri;
                var functions = Specializer.UnaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).literal(Host, uri, generic, path, Wf.Ct)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).literal(Host, uri, generic, path, Wf.Ct)));
                }
            }
        }

        void EmitUnrefinedBinary(in CaptureExchange exchange, OpIdentity gid, DirectApiMethod[] methods, Imm8R[] imm8, IAsmImmWriter dst)
        {
            var generic = false;

            foreach(var f in methods)
            {
                var host = f.Host;
                var uri = host.Uri;
                var functions = Specializer.BinaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).literal(Host, uri, generic, path, Wf.Ct)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).literal(Host, uri, generic, path, Wf.Ct)));
                }
            }
        }

        void EmitUnary(in CaptureExchange exchange, ApiMethodG src, Imm8R[] imm8, IAsmImmWriter dst, Type refinement = null)
        {
            var gid = src.Id;
            var uri = src.Host.Uri;
            var generic = true;
            foreach(var closure in src.Close())
            {
                var functions = Specializer.UnaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).define(Host, uri, generic, path, refinement, Wf.Ct)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).define(Host, uri, generic, path, refinement, Wf.Ct)));
                }
            }
        }

        void EmitBinary(in CaptureExchange exchange, ApiMethodG src, Imm8R[] imm8, IAsmImmWriter dst, Type refinement = null)
        {
            var gid = src.Id;
            var host = src.Host.Uri;
            var generic = true;
            foreach(var closure in src.Close())
            {
                var functions = Specializer.BinaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).define(Host, host, generic, path, refinement, Wf.Ct)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(SpecializedImmEvent).define(Host, host, generic, path, refinement, Wf.Ct)));
                }
            }
        }
    }
}