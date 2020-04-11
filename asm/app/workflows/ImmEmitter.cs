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

    public interface IImmEmitter : IService
    {
        void Emit(params byte[] immediates);
    }

    public interface IImmEmiterRelay : IWorkflowRelay
    {
        EmittingImmInjections EmittingImmInjections => EmittingImmInjections.Empty;

    }

    sealed class ImmEmitterRelay : AppEventRelay,  IImmEmiterRelay
    {
        [MethodImpl(Inline)]
        public new static ImmEmitterRelay Create()
            => new ImmEmitterRelay();
    }

    public class ImmEmitter : IImmEmitter
    {                
        public static IImmEmitter Create(IContext context, IAppMsgSink sink, IApiSet api, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmitter(context, sink, decoder, api, dst);

        readonly IContext Context;

        readonly IApiSet ApiSet;

        readonly IApiCollector ApiCollector;

        readonly RootEmissionPaths Paths;

        readonly IImmSpecializer ImmSpecializer;

        readonly IAppMsgSink Sink;

        ImmEmitter(IContext context, IAppMsgSink sink, IAsmFunctionDecoder decoder, IApiSet api, FolderPath root)
        {
            Context = context;
            Sink = sink;
            ImmSpecializer = context.ImmSpecializer(decoder);
            ApiSet = api;
            Paths = RootEmissionPaths.Define(root);
            Paths.Clear();
            Relay = ConnectReceivers(ImmEmitterRelay.Create());
            ApiCollector = context.ApiCollector();
        }


        public void Report(IAppEvent e, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(e.Format(), color);

        readonly IAppEventRelay Relay;

        void Connect(IAppEventRelay relay, IAppEvent model, Action<IAppEvent> receiver)
        {
            relay.Subscribe(receiver, model);
        }

        IImmEmiterRelay ConnectReceivers(IImmEmiterRelay relay)
        {
            relay.EmittingImmInjections.Subscribe(relay,OnEvent);
            return relay;
        }

        void OnEvent(EmittingImmInjections e)
        {
            Report(e);
        }

        [MethodImpl(Inline)]
        ref readonly E Raise<E>(in E e)
            where E : IAppEvent
                => ref Relay.Raise(e);

        public void Emit(params byte[] imm8)
            => EmitImm(Context.ExtractExchange(OnCapture), imm8);

        void OnCapture(in AsmCaptureEvent data)
        {

        }

        IEnumerable<IApiHost> ApiHosts => ApiSet.Hosts;

        IAsmFunctionArchive Archive(IApiHost host)
            => Context.ImmFunctionArchive(host.UriPath, Paths.RootDir);

        void EmitImm(in OpExtractExchange exchange, byte[] imm8)
        {
            EmitDirect(exchange, imm8);
            EmitGeneric(exchange, imm8);
        }

        DirectApiGroup ImmGroup(IApiHost host, DirectApiGroup g)
            => DirectApiGroup.Define(host, g.GroupId, g.Members.Where(m => m.Method.AcceptsImmediate() && m.Method.ReturnsVector()));

        IEnumerable<DirectApiGroup> DirectImmGroups(IApiHost host)
            => from g in ApiCollector.CollectDirect(host)
                let immg = ImmGroup(host, g)
                where !immg.IsEmpty
                select g;
        
        void EmitDirect(in OpExtractExchange exchange, byte[] imm8)
        {
            foreach(var host in ApiHosts)
            {
                Raise(EmittingImmInjections.Define(host.UriPath, false));
                var archive = Archive(host).Clear();
                var groups = DirectImmGroups(host);
                Emit(exchange, groups,imm8, archive);
            }
        }

        void Emit(in OpExtractExchange exchange, IEnumerable<DirectApiGroup> groups, byte[] imm8, IAsmFunctionArchive dst)
        {            
            var unary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedUnaryImm())
                        select (g,members);
            foreach(var (g,members) in unary)
                EmitUnary(exchange, g.GroupId, members, imm8, dst);

            var binary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedBinaryImm())
                        select (g,members);

            foreach(var (g,members) in binary)
                EmitBinary(exchange, g.GroupId, members, imm8, dst);
        }

        void EmitGeneric(in OpExtractExchange exchange, byte[] imm8)
        {        
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                var specs = ApiCollector.CollectGeneric(host).Where(op => op.Method.AcceptsImmediate());
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
            if(f.Method.IsVectorizedUnaryImm())
                EmitUnary(exchange, f, imm8, dst);           
            else if(f.Method.IsVectorizedBinaryImm())
                EmitBinary(exchange, f, imm8, dst);
        }
    }
}