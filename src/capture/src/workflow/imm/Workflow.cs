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
    using System.Collections.Generic;

    using static Seed;
    using static Memories;
    using static CaptureWorkflowEvents;
    using static ImmEmissionEvents;

    public class ImmEmissionWorkflow : IImmEmissionWorkflow
    {                        
        public static IImmEmissionWorkflow Create(IAsmContext context, IAppMsgSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmissionWorkflow(context, sink, formatter, decoder, api, dst);

        public IImmEmissionBroker Broker {get;} 

        public IAppMsgSink Sink {get;}

        internal ImmEmissionWorkflow(IAsmContext context, IAppMsgSink sink, IAsmFormatter formatter, IAsmFunctionDecoder decoder, IApiSet api, FolderPath root)
        {
            Broker = ImmEmissionBroker.New;
            Context = context;
            Sink = sink;
            Formatter = formatter;
            Decoder = decoder;
            ImmSpecializer = Capture.Services.ImmSpecializer(decoder);
            ApiSet = api;
            CodeArchive = Archives.Services.CaptureArchive(root);
            ApiCollector =  Identities.Services.ApiCollector;
            ConnectReceivers(Broker);
        }

        bool Append = true;

        IWorkflow<IImmEmissionBroker> Flow => this;
        
        readonly IApiSet ApiSet;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly IApiCollector ApiCollector;

        readonly ICaptureArchive CodeArchive;

        readonly IImmSpecializer ImmSpecializer;

        readonly IAsmContext Context;

        void ConnectReceivers(IImmEmissionBroker relay)
        {
            relay.EmittedEmbeddedImm.Subscribe(relay, OnEvent);          
            relay.HostFileEmissionFailed.Subscribe(relay, OnEvent);
            relay.ImmInjectionFailed.Subscribe(relay,OnEvent);            
        }

        void OnEvent(EmittedEmbeddedImm e)
        {
            Flow.Report(e);
        }

        void OnEvent(FileEmissionFailed e)
        {
            Flow.Report(e);
        }

        void OnEvent(ImmInjectionFailed e)
        {
            Flow.Report(e);
        }

        public void ClearArchive()
        {
            CodeArchive.ImmRootDir.Delete();
        }

        public void EmitLiteral(params byte[] imm8)
        {
            if(imm8.Length != 0)
            {
                var exchange =  AsmWorkflows.Create(Context).CaptureExchange;
                EmitUnrefined(exchange, imm8.ToImm8Values(ImmSourceKind.Literal));
            }
        }

        public void EmitRefined()
        {
            var exchange = AsmWorkflows.Create(Context).CaptureExchange;
            EmitRefined(exchange);
        }

        ParameterInfo RefiningParameter(MethodInfo src)
            => src.ImmParameters(ImmRefinementKind.Refined).First();

        Type RefinementType(MethodInfo src)
            => src.ImmParameters(ImmRefinementKind.Refined).First().ParameterType;

        Imm8Value[] RefinedValues(MethodInfo src)
            => RefiningParameter(src).RefinedImmValues();

        void EmitDirectRefinements(in CaptureExchange exchange, IApiHost host, IHostArchiver dst)
        {            
            var archive = Archive(host);
            var rfk = ImmRefinementKind.Refined;
            var groups = ApiCollector.ImmDirect(host, rfk);
            var uri = host.UriPath;
            var generic = false;
            foreach(var g in groups)
            {
                var gid = g.GroupId;
                foreach(var member in g.Members)
                {
                    if(member.Method.IsVectorizedUnaryImm(rfk))
                    {
                        var imm8 = RefinedValues(member.Method);
                        if(imm8.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = ImmSpecializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                            if(functions.Length != 0)
                            {
                                dst.SaveImmInjectedHex(gid, functions, Append)
                                    .OnSome(path => Broker.Raise(EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
                                dst.SaveImmInjectedAsm(gid, functions, Append)
                                    .OnSome(path => Broker.Raise(EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
                            }
                        }
                    }
                    else if(member.Method.IsVectorizedBinaryImm(rfk))
                    {
                        var imm8 = RefinedValues(member.Method);
                        if(imm8.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = ImmSpecializer.BinaryOps(exchange, member.Method, member.Id, imm8);
                            if(functions.Length != 0)
                            {
                                dst.SaveImmInjectedHex(gid, functions, Append)
                                    .OnSome(path => Broker.Raise(EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
                                dst.SaveImmInjectedAsm(gid, functions, Append)
                                    .OnSome(path => Broker.Raise(EmittedEmbeddedImm.Refined(uri, generic, rft, path)));
                            }
                        }
                    }
                }
            }
        }

        IEnumerable<IApiHost> ApiHosts => ApiSet.Hosts;

        IHostArchiver Archive(IApiHost host)
            => AsmCore.Services.HostArchiver(host.UriPath, Formatter, CodeArchive.RootDir);

        void EmitUnrefined(in CaptureExchange exchange, Imm8Value[] imm8)
        {
            EmitUnrefinedDirect(exchange, imm8);
            EmitUnrefinedGeneric(exchange, imm8);            
        }
        
        void EmitRefined(in CaptureExchange exchange)
        {
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                EmitDirectRefinements(exchange, host, archive);                
                EmitGenericRefinements(exchange, host, archive);
            }            
        }

        void EmitUnrefinedDirect(in CaptureExchange exchange, Imm8Value[] imm8)
        {            
            var rfk = ImmRefinementKind.Unrefined;
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                var groups = ApiCollector.ImmDirect(host, rfk);
                EmitUnrefinedDirect(exchange, groups,imm8, archive);
            }
        }

        void EmitUnrefinedDirect(in CaptureExchange exchange, IEnumerable<DirectApiGroup> groups, Imm8Value[] imm8, IHostArchiver dst)
        {            
            var rfk = ImmRefinementKind.Unrefined;
            var unary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedUnaryImm(rfk))
                        select (g,members);
            foreach(var (g,members) in unary)
                EmitUnrefinedUnary(exchange, g.GroupId, members, imm8, dst);

            var binary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedBinaryImm(rfk))
                        select (g,members);

            foreach(var (g,members) in binary)
                EmitUnrefinedBinary(exchange, g.GroupId, members, imm8, dst);
        }

        void EmitUnrefinedGeneric(in CaptureExchange exchange, Imm8Value[] imm8)
        {        
            var rfk = ImmRefinementKind.Unrefined;
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                var specs = ApiCollector.ImmGeneric(host, rfk);
                foreach(var spec in specs)
                    EmitUnrefinedGeneric(exchange, spec, imm8, archive); 
            }        
        }

        void EmitGenericRefinements(in CaptureExchange exchange, IApiHost host, IHostArchiver dst)
        {            
            var rfk = ImmRefinementKind.Refined;
            var specs = ApiCollector.ImmGeneric(host, rfk);
            foreach(var f in specs)
            {                    
                if(f.Method.IsVectorizedUnaryImm(rfk))
                {
                    EmitUnary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method));
                }
                else if(f.Method.IsVectorizedBinaryImm(rfk))
                {
                    EmitBinary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method));
                }
            }        
        }

        void EmitUnrefinedGeneric(in CaptureExchange exchange, GenericApiOp f,  Imm8Value[] imm8, IHostArchiver dst)
        {
            var rfk = ImmRefinementKind.Unrefined;
            if(f.Method.IsVectorizedUnaryImm(rfk))
                EmitUnary(exchange, f, imm8, dst);                       
            else if(f.Method.IsVectorizedBinaryImm(rfk))
                EmitBinary(exchange, f, imm8, dst);
        }

        void EmitUnrefinedUnary(in CaptureExchange exchange, OpIdentity gid, IEnumerable<DirectApiOp> unary, Imm8Value[] imm8, IHostArchiver dst)
        {
            var generic = false;
            foreach(var f in unary)
            {
                var host = f.HostUri;
                var functions = ImmSpecializer.UnaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveImmInjectedHex(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Literal(host, generic, path));
                    dst.SaveImmInjectedAsm(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Literal(host, generic, path));
                }
            }
        }

        void EmitUnrefinedBinary(in CaptureExchange exchange, OpIdentity gid, IEnumerable<DirectApiOp> binary, Imm8Value[] imm8, IHostArchiver dst)
        {
            var generic = false;
            foreach(var f in binary)
            {
                var host = f.HostUri;
                var functions = ImmSpecializer.BinaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveImmInjectedHex(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Literal(host, generic, path));
                    dst.SaveImmInjectedAsm(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Literal(host, generic, path));
                }
            }
        }

        void EmitUnary(in CaptureExchange exchange, GenericApiOp f, Imm8Value[] imm8, IHostArchiver dst, Type refinement = null)
        {
            var gid = f.Id;
            var host = f.HostUri;
            var generic = true;
            foreach(var closure in f.Close())
            {
                var functions = ImmSpecializer.UnaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveImmInjectedHex(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Create(host, generic, path, refinement));
                    dst.SaveImmInjectedAsm(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Create(host, generic, path, refinement));
                }
            }
        }

        void EmitBinary(in CaptureExchange exchange, GenericApiOp f, Imm8Value[] imm8, IHostArchiver dst, Type refinement = null)
        {
            var gid = f.Id;
            var host = f.HostUri;
            var generic = true;
            foreach(var closure in f.Close())
            {
                var functions = ImmSpecializer.BinaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    dst.SaveImmInjectedHex(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Create(host, generic, path, refinement));
                    dst.SaveImmInjectedAsm(gid, functions, Append).OnSome(path => EmittedEmbeddedImm.Create(host, generic, path, refinement));
                }
            }
        }
    }
}