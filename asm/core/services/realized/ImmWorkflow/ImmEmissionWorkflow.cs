//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;
    using static AsmEvents;

    public class ImmEmissionWorkflow : IAsmWorkflow<ImmEmissionWorkflow,ImmEmissionBroker>, IImmEmissionWorkflow
    {                
        public static IImmEmissionWorkflow Create(IContext context, IAppMsgSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmissionWorkflow(context, sink, formatter, decoder, api, dst);

        public ImmEmissionBroker Broker {get;} 
            = new ImmEmissionBroker();

        public IAppMsgSink Sink {get;}

        ImmEmissionWorkflow(IContext context, IAppMsgSink sink, IAsmFormatter formatter, IAsmFunctionDecoder decoder, IApiSet api, FolderPath root)
        {
            Context = context;
            Sink = sink;
            Formatter = formatter;
            Decoder = decoder;
            ImmSpecializer = context.ImmSpecializer(decoder);
            ApiSet = api;
            CodeArchive = CaptureArchive.Define(root + FolderName.Define("imm"));
            CodeArchive.Clear();
            ApiCollector = context.ApiCollector();
            ConnectReceivers(Broker);
        }

        IAsmWorkflow<ImmEmissionBroker> Flow => this;

        readonly IApiSet ApiSet;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly IApiCollector ApiCollector;

        readonly ICaptureArchive CodeArchive;

        readonly IImmSpecializer ImmSpecializer;

        readonly IContext Context;

        void ConnectReceivers(IImmEmissionStep relay)
        {
            relay.EmittingImmTargets.Subscribe(relay,OnEvent);  
            relay.EmittedImmRefinements.Subscribe(relay,OnEvent);          
            relay.HostFileEmissionFailed.Subscribe(relay,OnEvent);
        }

        void OnEvent(EmittingImmTargets e)
        {
            
        }

        void OnEvent(EmittedImmRefinements e)
        {
            Flow.Report(e);
        }

        void OnEvent(HostFileEmissionFailed e)
        {
            Flow.Report(e);
        }

        public void Emit(params byte[] imm8)
            => EmitImm(Context.ExtractExchange(), imm8);

        void EmitDirectRefinements(in CaptureExchange exchange, IApiHost host, IHostAsmArchiver dst)
        {            
            var archive = Archive(host);
            archive.Clear();
            var groups = ApiCollector.ImmDirect(host, ImmRefinementKind.Refined);
            foreach(var g in groups)
            {
                foreach(var member in g.Members)
                {
                    if(member.Method.IsVectorizedUnaryImm(ImmRefinementKind.Refined))
                    {
                        var immParam = member.Method.ImmParameters(ImmRefinementKind.Refined).First();
                        var imm8 = immParam.RefinedImmValues();
                        var functions = ImmSpecializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                        if(functions.Length != 0)
                        {
                            var fg = AsmFunctionGroup.Define(g.GroupId, functions);
                            dst.SaveHex(fg.Members, true)
                                .OnSome(path => Flow.Raise(EmittedImmRefinements.Define(host.UriPath, false, immParam.ParameterType, path)));
                            dst.SaveAsm(fg.Members, true)
                                .OnSome(path => Flow.Raise(EmittedImmRefinements.Define(host.UriPath, false, immParam.ParameterType, path)))
                            ;
                        }
                    }
                    else if(member.Method.IsVectorizedBinaryImm(ImmRefinementKind.Refined))
                    {
                        var immParam = member.Method.ImmParameters(ImmRefinementKind.Refined).First();
                        var imm8 = immParam.RefinedImmValues();
                        var functions = ImmSpecializer.BinaryOps(exchange, member.Method, member.Id, imm8);
                        if(functions.Length != 0)
                        {
                            var fg = AsmFunctionGroup.Define(g.GroupId, functions);
                            dst.SaveHex(fg.Members, true)
                                .OnSome(path => Flow.Raise(EmittedImmRefinements.Define(host.UriPath, false, immParam.ParameterType, path)));
                            dst.SaveAsm(fg.Members, true)
                                .OnSome(path => Flow.Raise(EmittedImmRefinements.Define(host.UriPath, false, immParam.ParameterType, path)));
                        }

                    }
                }
            }
        }

        IEnumerable<IApiHost> ApiHosts => ApiSet.Hosts;

        IHostAsmArchiver Archive(IApiHost host)
            => Context.ImmFunctionArchive(host.UriPath, Formatter, CodeArchive.RootDir);

        void EmitImm(in CaptureExchange exchange, byte[] imm8)
        {
            EmitDirect(exchange, imm8);
            EmitGeneric(exchange, imm8);            
        }
        
        void EmitDirect(in CaptureExchange exchange, byte[] imm8)
        {            
            foreach(var host in ApiHosts)
            {
                Flow.Raise(EmittingImmTargets.Define(host.UriPath, false));
                var archive = Archive(host);
                archive.Clear();
                var groups = ApiCollector.ImmDirect(host, ImmRefinementKind.Unrefined);
                Emit(exchange, groups,imm8, archive);
                EmitDirectRefinements(exchange, host, archive);
            }
        }

        void Emit(in CaptureExchange exchange, IEnumerable<DirectApiGroup> groups, byte[] imm8, IHostAsmArchiver dst)
        {            
            var unary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedUnaryImm(ImmRefinementKind.Unrefined))
                        select (g,members);
            foreach(var (g,members) in unary)
                EmitUnary(exchange, g.GroupId, members, imm8, dst);

            var binary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedBinaryImm(ImmRefinementKind.Unrefined))
                        select (g,members);

            foreach(var (g,members) in binary)
                EmitBinary(exchange, g.GroupId, members, imm8, dst);
        }

        void EmitGeneric(in CaptureExchange exchange, byte[] imm8)
        {        
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                var specs = ApiCollector.ImmGeneric(host,ImmRefinementKind.Unrefined);
                foreach(var spec in specs)
                    Emit(exchange, spec, imm8, archive); 
            }        
        }

        void EmitUnary(in CaptureExchange exchange, OpIdentity idGroup, IEnumerable<DirectApiOp> unary, byte[] imm8, IHostAsmArchiver dst)
        {
            foreach(var member in unary)
            {
                var functions = ImmSpecializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(idGroup, functions), true);                    
            }
        }

        void EmitBinary(in CaptureExchange exchange, OpIdentity idGroup,  IEnumerable<DirectApiOp> binary, byte[] imm8, IHostAsmArchiver dst)
        {
            foreach(var member in binary)
            {
                var functions = ImmSpecializer.BinaryOps(exchange, member.Method, member.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(idGroup, functions), true);                    
            }
        }

        void EmitUnary(in CaptureExchange exchange, GenericApiOp f, byte[] imm8, IHostAsmArchiver dst)
        {
            foreach(var closure in f.Close())
            {
                var functions = ImmSpecializer.UnaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(f.GenericId, functions), true);
            }
        }

        void EmitBinary(in CaptureExchange exchange, GenericApiOp f, byte[] imm8,  IHostAsmArchiver dst)
        {
            foreach(var closure in f.Close())
            {
                var functions = ImmSpecializer.BinaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(f.GenericId, functions), true);
            }
        }

        void Emit(in CaptureExchange exchange, GenericApiOp f,  byte[] imm8, IHostAsmArchiver dst)
        {
            if(f.Method.IsVectorizedUnaryImm(ImmRefinementKind.Unrefined))
                EmitUnary(exchange, f, imm8, dst);           
            else if(f.Method.IsVectorizedBinaryImm(ImmRefinementKind.Unrefined))
                EmitBinary(exchange, f, imm8, dst);
        }
    }
}