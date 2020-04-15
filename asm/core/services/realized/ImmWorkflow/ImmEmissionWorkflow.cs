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

    public sealed class ImmEmitterRelay : AppEventRelay,  IImmEmissionRelay
    {
        [MethodImpl(Inline)]
        public new static ImmEmitterRelay Create()
            => new ImmEmitterRelay();
    }

    public class ImmEmissionWorkflow : IAsmWorkflow<ImmEmissionWorkflow,ImmEmitterRelay>, IImmEmissionWorkflow
    {                
        public static IImmEmissionWorkflow Create(IContext context, IAppMsgSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmissionWorkflow(context, sink, formatter, decoder, api, dst);

        public ImmEmitterRelay Relay {get;} 
            = new ImmEmitterRelay();

        public IAppMsgSink Sink {get;}

        ImmEmissionWorkflow(IContext context, IAppMsgSink sink, IAsmFormatter formatter, IAsmFunctionDecoder decoder, IApiSet api, FolderPath root)
        {
            Context = context;
            Sink = sink;
            Formatter = formatter;
            Decoder = decoder;
            ImmSpecializer = context.ImmSpecializer(decoder);
            ApiSet = api;
            Paths = RootEmissionPaths.Define(root);
            Paths.Clear();
            ApiCollector = context.ApiCollector();
            ConnectReceivers(Relay);
        }

        IAsmWorkflow<ImmEmitterRelay> Flow => this;

        readonly IApiSet ApiSet;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly IApiCollector ApiCollector;

        readonly RootEmissionPaths Paths;

        readonly IImmSpecializer ImmSpecializer;

        readonly IContext Context;

        void ConnectReceivers(IImmEmissionRelay relay)
        {
            relay.EmittingImmInjections.Subscribe(relay,OnEvent);            
        }

        void OnEvent(EmittingImmInjections e)
        {
            Flow.Report(e);
        }

        public void Emit(params byte[] imm8)
            => EmitImm(Context.ExtractExchange(), imm8);


        void EmitDirectRefinements(in OpExtractExchange exchange, IApiHost host, IAsmFunctionArchive dst)
        {            
            Flow.Raise(EmittingImmInjections.Define(host.UriPath, false));
            var archive = Archive(host).Clear();
            var groups = ApiCollector.ImmDirect(host, ImmRefinementKind.Refined);
            foreach(var g in groups)
            {
                foreach(var member in g.Members)
                {
                    if(member.Method.IsVectorizedUnaryImm(ImmRefinementKind.Refined))
                    {
                        var imm8 = member.Method.ImmParameters(ImmRefinementKind.Refined).First().RefinedImmValues();
                        var functions = ImmSpecializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                        if(functions.Length != 0)
                            dst.Save(AsmFunctionGroup.Define(g.GroupId, functions), true);                    
                    }
                    else if(member.Method.IsVectorizedBinaryImm(ImmRefinementKind.Refined))
                    {
                        var imm8 = member.Method.ImmParameters(ImmRefinementKind.Refined).First().RefinedImmValues();
                        var functions = ImmSpecializer.BinaryOps(exchange, member.Method, member.Id, imm8);
                        if(functions.Length != 0)
                            dst.Save(AsmFunctionGroup.Define(g.GroupId, functions), true);                    

                    }
                }
            }
        }

        IEnumerable<IApiHost> ApiHosts => ApiSet.Hosts;

        IAsmFunctionArchive Archive(IApiHost host)
            => Context.ImmFunctionArchive(host.UriPath, Formatter, Paths.RootDir);

        void EmitImm(in OpExtractExchange exchange, byte[] imm8)
        {
            EmitDirect(exchange, imm8);
            EmitGeneric(exchange, imm8);            
        }
        
        void EmitDirect(in OpExtractExchange exchange, byte[] imm8)
        {            
            foreach(var host in ApiHosts)
            {
                Flow.Raise(EmittingImmInjections.Define(host.UriPath, false));
                var archive = Archive(host).Clear();
                var groups = ApiCollector.ImmDirect(host, ImmRefinementKind.Unrefined);
                Emit(exchange, groups,imm8, archive);
                //EmitDirectRefinements(exchange, host, archive);

            }
        }

        void Emit(in OpExtractExchange exchange, IEnumerable<DirectApiGroup> groups, byte[] imm8, IAsmFunctionArchive dst)
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

        void EmitGeneric(in OpExtractExchange exchange, byte[] imm8)
        {        
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                var specs = ApiCollector.ImmGeneric(host,ImmRefinementKind.Unrefined);
                foreach(var spec in specs)
                    Emit(exchange, spec, imm8, archive); 
            }        
        }

        void EmitUnary(in OpExtractExchange exchange, OpIdentity idGroup, IEnumerable<DirectApiOp> unary, byte[] imm8, IAsmFunctionArchive dst)
        {
            foreach(var member in unary)
            {
                var functions = ImmSpecializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(idGroup, functions), true);                    
            }
        }

        void EmitBinary(in OpExtractExchange exchange, OpIdentity idGroup,  IEnumerable<DirectApiOp> binary, byte[] imm8, IAsmFunctionArchive dst)
        {
            foreach(var member in binary)
            {
                var functions = ImmSpecializer.BinaryOps(exchange, member.Method, member.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(idGroup, functions), true);                    
            }
        }

        void EmitUnary(in OpExtractExchange exchange, GenericApiOp f, byte[] imm8, IAsmFunctionArchive dst)
        {
            foreach(var closure in f.Close())
            {
                var functions = ImmSpecializer.UnaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(f.GenericId, functions), true);
            }
        }

        void EmitBinary(in OpExtractExchange exchange, GenericApiOp f, byte[] imm8,  IAsmFunctionArchive dst)
        {
            foreach(var closure in f.Close())
            {
                var functions = ImmSpecializer.BinaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                    dst.Save(AsmFunctionGroup.Define(f.GenericId, functions), true);
            }
        }

        void Emit(in OpExtractExchange exchange, GenericApiOp f,  byte[] imm8, IAsmFunctionArchive dst)
        {
            if(f.Method.IsVectorizedUnaryImm(ImmRefinementKind.Unrefined))
                EmitUnary(exchange, f, imm8, dst);           
            else if(f.Method.IsVectorizedBinaryImm(ImmRefinementKind.Unrefined))
                EmitBinary(exchange, f, imm8, dst);
        }
    }
}