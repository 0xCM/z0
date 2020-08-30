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
    using static z;

    public class EmitImmSpecials : IImmEmitter
    {
        public CorrelationToken Ct {get;}

        public IWfImmBroker Broker {get;}

        readonly IAsmContext Context;

        public IMultiSink Sink {get;}

        readonly IApiSet ApiSet;

        readonly IAsmFormatter Formatter;

        readonly IAsmDecoder Decoder;

        readonly IApiCollector ApiCollector;

        readonly IPartCapturePaths CodeArchive;

        readonly IImmSpecializer Specializer;

        readonly IWfEventLog Log;

        internal EmitImmSpecials(IAsmContext context, WfConfig config, IMultiSink sink, IAsmFormatter formatter, IAsmDecoder decoder, IApiSet api, FolderPath root, CorrelationToken? ct = null)
        {
            Ct = correlate(ct);
            Log = AB.log(config);
            Broker = AsmWfBuilder.imm(Log, Ct);
            Context = context;
            Sink = sink;
            Formatter = formatter;
            Decoder = decoder;
            ApiSet = api;
            CodeArchive = Archives.capture(root);
            Specializer = Capture.Services.ImmSpecializer(decoder);
            ApiCollector =  Identities.Services.Collector;
            ConnectReceivers(Broker);
        }

        public void Dispose()
        {
            Broker.Dispose();
            Log.Dispose();
        }

        bool Append = true;

        void ConnectReceivers(IWfImmBroker relay)
        {
            relay.EmittedEmbeddedImm.Subscribe(relay, OnEvent);
            relay.HostFileEmissionFailed.Subscribe(relay, OnEvent);
            relay.ImmInjectionFailed.Subscribe(relay,OnEvent);
        }

        void OnEvent(EmittedEmbeddedImm e)
        {
            Sink.Deposit(e);
        }

        void OnEvent(FileEmissionFailed e)
        {
            Sink.Deposit(e);
        }

        void OnEvent(ImmInjectionFailed e)
        {
            Sink.Deposit(e);
        }

        public void ClearArchive(params PartId[] parts)
        {
            if(parts.Length != 0)
                CodeArchive.ImmHostDirs(parts).Delete();
            else
                CodeArchive.ImmRootDir.Delete();
        }

        public void EmitLiteral(byte[] imm8, params PartId[] parts)
        {
            if(imm8.Length != 0)
            {
                //var exchange =  CaptureServices.create(Context).CaptureExchange;
                var exchange = Capture.exchange(Context);
                EmitUnrefined(exchange, imm8.ToImm8Values(ImmRefinementKind.Unrefined), parts);
            }
        }

        public void EmitRefined(params PartId[] parts)
        {
            var exchange = Capture.exchange(Context);
            //var exchange = CaptureServices.create(Context).CaptureExchange;
            EmitRefined(exchange, parts);
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
                                    .OnSome(path => Broker.Raise(Broker.EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
                                dst.SaveAsmImm(gid, functions, Append)
                                    .OnSome(path => Broker.Raise(Broker.EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
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
                                    .OnSome(path => Broker.Raise(Broker.EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
                                dst.SaveAsmImm(gid, functions, Append)
                                    .OnSome(path => Broker.Raise(Broker.EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
                            }
                        }
                    }
                }
            }
        }

        IEnumerable<ApiHost> Hosts(params PartId[] parts)
            => from h in ApiSet.DefinedHosts(parts)
                where h is ApiHost
                select (ApiHost)h;

        HostAsmArchiver Archive(IApiHost host)
            => AsmCore.Services.HostArchiver(host.Uri, Formatter, CodeArchive.ArchiveRoot);

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
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Literal(host, generic, path));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Literal(host, generic, path));
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
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Literal(host, generic, path));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Literal(host, generic, path));
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
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Create(host, generic, path, refinement));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Create(host, generic, path, refinement));
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
                    dst.SaveHexImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Create(host, generic, path, refinement));
                    dst.SaveAsmImm(gid, functions, Append).OnSome(path => Broker.EmittedEmbeddedImm.Create(host, generic, path, refinement));
                }
            }
        }
    }
}