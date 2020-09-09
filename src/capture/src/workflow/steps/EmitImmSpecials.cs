//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static EmitImmSpecialsStep;

    using static z;

    public class EmitImmSpecials : IImmEmitter
    {
        IWfShell Wf;

        readonly IAsmContext Context;

        readonly IAsmFormatter Formatter;

        readonly IApiCollector ApiCollector;

        readonly IPartCapturePaths CodeArchive;

        readonly IImmSpecializer Specializer;

        public EmitImmSpecials(IWfShell wf, IAsmContext context, IAsmFormatter formatter, IAsmDecoder decoder, FolderPath root, CorrelationToken? ct = null)
        {
            Wf = wf;
            Context = context;
            Formatter = formatter;
            CodeArchive = Archives.capture(root);
            Specializer = Capture.Services.ImmSpecializer(decoder);
            ApiCollector = Identities.Services.Collector;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
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
                var exchange = Capture.exchange(Context);
                EmitUnrefined(exchange, imm8.ToImm8Values(ImmRefinementKind.Unrefined), parts);
            }
        }

        public void EmitRefined(params PartId[] parts)
        {
            EmitRefined(Capture.exchange(Context), parts);
        }

        ParameterInfo RefiningParameter(MethodInfo src)
            => src.ImmParameters(ImmRefinementKind.Refined).First();

        Type RefinementType(MethodInfo src)
            => src.ImmParameters(ImmRefinementKind.Refined).First().ParameterType;

        Imm8R[] RefinedValues(MethodInfo src)
            => RefiningParameter(src).RefinedImmValues();

        void EmitDirectRefinements(in CaptureExchange exchange, ApiHost host, IHostAsmArchiver dst)
        {
            var archive = Archive(host);
            var groups = ApiCollector.ImmDirect(host, ImmRefinementKind.Refined);
            var uri = host.Uri;
            var generic = false;
            foreach(var g in groups)
            {
                var gid = g.GroupId;
                foreach(var member in g.Members)
                {
                    if(member.Method.IsVectorizedUnaryImm(ImmRefinementKind.Refined))
                    {
                        var imm8 = RefinedValues(member.Method);
                        if(imm8.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = Specializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                            if(functions.Length != 0)
                            {
                                dst.SaveHexImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Refined(uri, generic, rft, path)));
                                dst.SaveAsmImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Refined(uri, generic, rft, path)));
                            }
                        }
                    }
                    else if(member.Method.IsVectorizedBinaryImm(ImmRefinementKind.Refined))
                    {
                        var values = RefinedValues(member.Method);
                        if(values.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = Specializer.BinaryOps(exchange, member.Method, member.Id, values);
                            if(functions.Length != 0)
                            {
                                dst.SaveHexImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Refined(uri, generic, rft, path)));
                                dst.SaveAsmImm(gid, functions, Append)
                                    .OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Refined(uri, generic, rft, path)));
                            }
                        }
                    }
                }
            }
        }

        IEnumerable<ApiHost> Hosts(params PartId[] parts)
            => from h in Wf.Api.DefinedHosts(parts)
                where h is ApiHost
                select (ApiHost)h;

        HostAsmArchiver Archive(IApiHost host)
            => AsmServices.Services.HostArchiver(host.Uri, Formatter, CodeArchive.ArchiveRoot);

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
                var groups = ApiCollector.ImmDirect(host, ImmRefinementKind.Unrefined);
                EmitUnrefinedDirect(exchange, groups,imm8, archive);
            }
        }

        void EmitUnrefinedDirect(in CaptureExchange exchange, IEnumerable<DirectApiGroup> groups, Imm8R[] imm8, IHostAsmArchiver dst)
        {
            var unary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedUnaryImm(ImmRefinementKind.Unrefined))
                        select (g,members);

            foreach(var (g,members) in unary)
                EmitUnrefinedUnary(exchange, g.GroupId, members, imm8, dst);

            var binary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedBinaryImm(ImmRefinementKind.Unrefined))
                        select (g,members);

            foreach(var (g,members) in binary)
                EmitUnrefinedBinary(exchange, g.GroupId, members, imm8, dst);
        }

        void EmitUnrefinedGeneric(in CaptureExchange exchange, Imm8R[] imm8, params PartId[] parts)
        {
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host);
                var specs = ApiCollector.ImmGeneric(host, ImmRefinementKind.Unrefined);
                foreach(var spec in specs)
                    EmitUnrefinedGeneric(exchange, spec, imm8, archive);
            }
        }

        void EmitGenericRefinements(in CaptureExchange exchange, ApiHost host, IHostAsmArchiver dst)
        {
            var specs = ApiCollector.ImmGeneric(host, ImmRefinementKind.Refined);
            foreach(var f in specs)
            {
                if(f.Method.IsVectorizedUnaryImm(ImmRefinementKind.Refined))
                    EmitUnary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method));
                else if(f.Method.IsVectorizedBinaryImm(ImmRefinementKind.Refined))
                    EmitBinary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method));
            }
        }

        void EmitUnrefinedGeneric(in CaptureExchange exchange, GenericApiMethod f,  Imm8R[] imm8, IHostAsmArchiver dst)
        {
            if(f.Method.IsVectorizedUnaryImm(ImmRefinementKind.Unrefined))
                EmitUnary(exchange, f, imm8, dst);
            else if(f.Method.IsVectorizedBinaryImm(ImmRefinementKind.Unrefined))
                EmitBinary(exchange, f, imm8, dst);
        }

        void EmitUnrefinedUnary(in CaptureExchange exchange, OpIdentity gid, IEnumerable<DirectApiMethod> unary, Imm8R[] imm8, IHostAsmArchiver dst)
        {
            var generic = false;
            foreach(var f in unary)
            {
                var host = f.HostUri;
                var functions = Specializer.UnaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Literal(host, generic, path)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Literal(host, generic, path)));
                }
            }
        }

        void EmitUnrefinedBinary(in CaptureExchange exchange, OpIdentity gid, IEnumerable<DirectApiMethod> binary, Imm8R[] imm8, IHostAsmArchiver dst)
        {
            var generic = false;
            foreach(var f in binary)
            {
                var host = f.HostUri;
                var functions = Specializer.BinaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Literal(host, generic, path)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Literal(host, generic, path)));
                }
            }
        }

        void EmitUnary(in CaptureExchange exchange, GenericApiMethod f, Imm8R[] imm8, IHostAsmArchiver dst, Type refinement = null)
        {
            var gid = f.Id;
            var host = f.HostUri;
            var generic = true;
            foreach(var closure in f.Close())
            {
                var functions = Specializer.UnaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Create(host, generic, path, refinement)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Create(host, generic, path, refinement)));
                }
            }
        }

        void EmitBinary(in CaptureExchange exchange, GenericApiMethod f, Imm8R[] imm8, IHostAsmArchiver dst, Type refinement = null)
        {
            var gid = f.Id;
            var host = f.HostUri;
            var generic = true;
            foreach(var closure in f.Close())
            {
                var functions = Specializer.BinaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Create(host, generic, path, refinement)));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Wf.Raise(default(EmittedEmbeddedImm).Create(host, generic, path, refinement)));
                }
            }
        }
    }
}