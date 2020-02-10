//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using Z0.AsmSpecs;

    using static AsmServiceMessages;

    using static zfunc;
    using Z0;

    class AsmCatalogEmitter : IAsmCatalogEmitter, ICaptureTokenSink
    {
        [MethodImpl(Inline)]
        public static IAsmCatalogEmitter Create(IAsmContext context, IOperationCatalog catalog, ICaptureTokenSink observer)
            => new AsmCatalogEmitter(context,catalog,observer);

        [MethodImpl(Inline)]
        AsmCatalogEmitter(IAsmContext context, IOperationCatalog catalog, ICaptureTokenSink observer)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Decoder = Context.Decoder();
            this.Observer = observer != null ? some(observer) : none<ICaptureTokenSink>();
        }

        public IAsmContext Context {get;}

        readonly IOperationCatalog Catalog;

        readonly IAsmDecoder Decoder;

        readonly Option<ICaptureTokenSink> Observer;

        ICaptureTokenSink Sink
        {
            [MethodImpl(Inline)]
            get => this;
        }
        
        void IAsmCatalogEmitter.EmitPrimary(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt)
        {
            var sink = CaptureServices.EmissionSink(receipt);
            ClearArchives(false);
            EmitDirectPrimary(exchange,receipt);
            EmitGenericPrimary(exchange,receipt);
        }

        void IAsmCatalogEmitter.EmitImm(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt)
        {
            var sink = CaptureServices.EmissionSink(receipt);
            ClearArchives(true);
            EmitDirectImm(exchange,receipt);
            EmitGenericImm(exchange,receipt);
        }

        void EmitDirectPrimary(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt)
        {            
            foreach(var host in Catalog.DirectApiHosts)
                EmitDirectPrimary(exchange, host, receipt);
        }

        void EmitDirectImm(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt)
        {
            foreach(var host in Catalog.DirectApiHosts)
            {
                var archive = HostImmArchive(host);
                var specs = from g in OpSpecs.groups(host)
                             let immg = ImmGroup(g)
                             where !immg.IsEmpty
                             select immg;
                
                foreach(var g in specs)
                    EmitDirectImm(exchange, g, archive, receipt);
            }
        }

        void EmitGenericPrimary(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt)
        {
            foreach(var host in Catalog.GenericApiHosts)                
                EmitGenericPrimary(exchange, host, receipt);
        }

        void EmitGenericImm(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt)
        {
        
            foreach(var host in Catalog.GenericApiHosts)
            {
                var archive = HostImmArchive(host);
                var specs = OpSpecs.generic(host).Where(op => FunctionType.immneeds(op.Root));

                foreach(var spec in specs)
                    EmitGenericImm(exchange, spec, archive, receipt);                
            }        
        }

        void EmitDirectPrimary(in CaptureExchange exchange, Type host, Action<CaptureTokenGroup> receipt)
        {
            var primary = HostArchive(host);
            var immediate = HostImmArchive(host);
            var specs = OpSpecs.groups(host);

            foreach(var spec in specs)
                Emit(exchange, PrimaryGroup(spec), primary, receipt);
        }

        void EmitGenericPrimary(in CaptureExchange exchange, Type host, Action<CaptureTokenGroup> receipt)
        {
            var primary = HostArchive(host);
            var immediate = HostImmArchive(host);
            var specs = OpSpecs.generic(host);

            foreach(var spec in specs.Where(spec => !FunctionType.immneeds(spec.Root)))
                Emit(exchange, spec, primary, receipt);
        }        

        void Emit(in CaptureExchange exchange, DirectOpGroupSpec group, IAsmFunctionArchive dst, Action<CaptureTokenGroup> receipt)
        {                                    
            var functions = new List<AsmFunction>();
            foreach(var spec in group.Members)
                functions.Add(Decode(exchange, spec.Id, spec.Root));
            
            if(functions.Count != 0)
            {
                var fGroup = AsmFunctionGroup.Define(group.Id, functions.ToArray());
                OnSave(dst.Save(fGroup, true), receipt);
                //tGroup.OnSome(receipt).OnSome(g => Sink.Accept(g));
            }                        
        }

        void Emit(in CaptureExchange exchange, GenericOpSpec op, IAsmFunctionArchive dst, Action<CaptureTokenGroup> receipt)
        {
            var functions = new List<AsmFunction>();
            foreach(var closure in op.Close())                        
                functions.Add(Decoder.DecodeFunction(in exchange, closure.Id, closure.ClosedMethod));
            if(functions.Count != 0)
            {
                var fGroup = AsmFunctionGroup.Define(op.Id, functions.ToArray());
                OnSave(dst.Save(fGroup, true), receipt);

            //var tGroup = dst.Save(fGroup, true);
               // tGroup.OnSome(receipt).OnSome(g => Sink.Accept(g));
            }
        }

        void EmitGenericImm(in CaptureExchange exchange, GenericOpSpec op, IAsmFunctionArchive dst, Action<CaptureTokenGroup> receipt)
        {
            if(FunctionType.vunaryImm(op.Root))
            {                                                
                foreach(var closure in op.Close())
                {
                    var svc = Context.UnaryImmCapture(closure.ClosedMethod, closure.Id);
                    var functions = svc.Capture(in exchange, ImmSelection);
                    if(functions.Length != 0)
                    {
                        var fGroup = AsmFunctionGroup.Define(op.Id, functions);
                        OnSave(dst.Save(fGroup, true), receipt);
                        //var tGroup = dst.Save(fGroup, true);                        
                        //tGroup.OnSome(receipt).OnSome(g => Sink.Accept(g));
                    }
                }
            }
            else if(FunctionType.vbinaryImm(op.Root))
            {
                foreach(var closure in op.Close())
                {
                    var svc = Context.BinaryImmCapture(closure.ClosedMethod, closure.Id);
                    var functions = svc.Capture(in exchange, ImmSelection);
                    if(functions.Length != 0)
                    {
                        var fGroup = AsmFunctionGroup.Define(op.Id, functions);
                        OnSave(dst.Save(fGroup, true), receipt);
                        // var tGroup = dst.Save(fGroup, true);                        
                        // tGroup.OnSome(receipt).OnSome(g => Sink.Accept(g));
                    }
                }
            }
        }

        void EmitDirectImm(in CaptureExchange exchange, DirectOpGroupSpec op, IAsmFunctionArchive dst, Action<CaptureTokenGroup> receipt)
        {
            var tokens = new List<CaptureToken>();
            foreach(var member in op.Members.Where(m => FunctionType.vunaryImm(m.Root)))
            {
                var resolutions = Context.UnaryImmCapture(member.Root, member.Id).Capture(in exchange, ImmSelection);
                if(resolutions.Length != 0)
                {
                    var fGroup = AsmFunctionGroup.Define(op.Id, resolutions.ToArray());
                    var tGroup = dst.Save(fGroup, true);
                    tGroup.OnSome(t => tokens.AddRange(t.Tokens)).OnSome(g => Sink.Accept(g));
                }
            }

            foreach(var member in op.Members.Where(m => FunctionType.vbinaryImm(m.Root)))
            {
                var resolutions = Context.BinaryImmCapture(member.Root, member.Id).Capture(in exchange, ImmSelection);
                if(resolutions.Length != 0)
                {
                    var fGroup = AsmFunctionGroup.Define(op.Id, resolutions.ToArray());
                    var tGroup = dst.Save(fGroup, true);
                    tGroup.OnSome(t => tokens.AddRange(t.Tokens)).OnSome(g => Sink.Accept(g));
                }
            }

            if(tokens.Count != 0)
                receipt(tokens.ToGroup(tokens[0].Uri.GroupUri));
        }                    

        DirectOpGroupSpec PrimaryGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => !FunctionType.immneeds(m.Root)));

        DirectOpGroupSpec ImmGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => FunctionType.immneeds(m.Root)));

        IEnumerable<Type> ApiHosts
            => Catalog.DirectApiHosts.Union(Catalog.GenericApiHosts);

        void ClearArchives(bool imm)
        {
            if(imm)
                iter(ApiHosts.Select(HostImmArchive), a => a.Clear());
            else
                iter(ApiHosts.Select(HostArchive), a => a.Clear());
        }    

        void OnSave(Option<CaptureTokenGroup> g, Action<CaptureTokenGroup> receipt)
        {
            g.OnSome(receipt).OnSome(g => Sink.Accept(g));
        }

        void IPointSink<CaptureTokenGroup>.Accept(in CaptureTokenGroup src)
        {
            if(Observer.IsSome())
                Observer.Value.Accept(src);
            else
            {
                foreach(var t in src.Tokens)
                    print(Emitted(t));
                //print(AsmServiceMessages.Emitted(src));
            }

        }

        string ArchiveSubject(Type host, bool imm)
            =>  host.HostName() + (imm ?  "_imm" : string.Empty);

        IAsmFunctionArchive HostArchive(Type host)
            => Archive(ArchiveSubject(host,false));

        IAsmFunctionArchive HostImmArchive(Type host)
            => Archive(ArchiveSubject(host,true));

        IAsmFunctionArchive Archive(string subject)
            => Context.FunctionArchive(Catalog.AssemblyId, subject);

        AsmFunction Decode(in CaptureExchange exchange, OpIdentity id, MethodInfo method)
            => Decoder.DecodeFunction(exchange, id, method);

        static byte[] ImmSelection => new byte[]{5,9,13};
    }
}