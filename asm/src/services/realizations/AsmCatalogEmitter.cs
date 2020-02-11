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
        public static IAsmCatalogEmitter Create(IAsmContext context, IOperationCatalog catalog, CaptureEmissionObserver observer)
            => new AsmCatalogEmitter(context,catalog,observer);

        [MethodImpl(Inline)]
        AsmCatalogEmitter(IAsmContext context, IOperationCatalog catalog, CaptureEmissionObserver observer)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Decoder = Context.Decoder();
            this.Observer = observer;
        }

        public IAsmContext Context {get;}

        readonly IOperationCatalog Catalog;

        readonly IAsmDecoder Decoder;

        readonly CaptureEmissionObserver Observer;

        ICaptureTokenSink Sink
        {
            [MethodImpl(Inline)]
            get => this;
        }
        
        void IAsmCatalogEmitter.EmitPrimary(in CaptureExchange exchange, CaptureEmissionObserver observer)
        {
            ClearArchives(false);
            EmitDirectPrimary(exchange,observer);
            EmitGenericPrimary(exchange,observer);
        }

        void IAsmCatalogEmitter.EmitImm(in CaptureExchange exchange, CaptureEmissionObserver observer)
        {
            ClearArchives(true);
            EmitDirectImm(exchange,observer);
            EmitGenericImm(exchange,observer);
        }

        void EmitDirectPrimary(in CaptureExchange exchange, CaptureEmissionObserver observer)
        {            
            foreach(var host in Catalog.DirectApiHosts)
                EmitDirectPrimary(exchange, host, observer);
        }

        void EmitDirectImm(in CaptureExchange exchange, CaptureEmissionObserver observer)
        {
            foreach(var host in Catalog.DirectApiHosts)
            {
                var archive = HostImmArchive(host);
                var specs = from g in OpSpecs.direct(host)
                             let immg = ImmGroup(g)
                             where !immg.IsEmpty
                             select immg;
                
                foreach(var g in specs)
                    EmitDirectImm(exchange, g, archive, observer);
            }
        }

        void EmitGenericPrimary(in CaptureExchange exchange, CaptureEmissionObserver observer)
        {
            foreach(var host in Catalog.GenericApiHosts)                
                EmitGenericPrimary(exchange, host, observer);
        }

        void EmitGenericImm(in CaptureExchange exchange, CaptureEmissionObserver observer)
        {        
            foreach(var host in Catalog.GenericApiHosts)
            {
                var archive = HostImmArchive(host);
                var specs = OpSpecs.generic(host).Where(op => FunctionType.immneeds(op.Root));

                foreach(var spec in specs)
                    EmitGenericImm(exchange, spec, archive, observer);                
            }        
        }

        void EmitDirectPrimary(in CaptureExchange exchange, ApiHost host, CaptureEmissionObserver observer)
        {
            var primary = HostArchive(host);
            var immediate = HostImmArchive(host);
            var specs = OpSpecs.direct(host);

            foreach(var spec in specs)
                Emit(exchange, PrimaryGroup(spec), primary, observer);
        }

        void EmitGenericPrimary(in CaptureExchange exchange, ApiHost host, CaptureEmissionObserver observer)
        {
            var primary = HostArchive(host);
            var immediate = HostImmArchive(host);
            var specs = OpSpecs.generic(host);

            foreach(var spec in specs.Where(spec => !FunctionType.immneeds(spec.Root)))
                Emit(exchange, spec, primary, observer);
        }        

        void Emit(in CaptureExchange exchange, DirectOpGroupSpec group, IAsmFunctionArchive dst, CaptureEmissionObserver observer)
        {                                    
            var functions = new List<AsmFunction>();
            foreach(var spec in group.Members)
                functions.Add(Decode(exchange, spec.Id, spec.Root));
            
            if(functions.Count != 0)
            {
                var fGroup = AsmFunctionGroup.Define(group.Id, functions.ToArray());
                OnSave(dst.Save(fGroup, true), observer);
            }                        
        }

        void Emit(in CaptureExchange exchange, GenericOpSpec op, IAsmFunctionArchive dst, CaptureEmissionObserver observer)
        {
            var functions = new List<AsmFunction>();
            foreach(var closure in op.Close())                        
                functions.Add(Decoder.Decode(in exchange, closure.Id, closure.ClosedMethod));
            if(functions.Count != 0)
            {
                var fGroup = AsmFunctionGroup.Define(op.Id, functions.ToArray());
                OnSave(dst.Save(fGroup, true), observer);
            }
        }

        void EmitGenericImm(in CaptureExchange exchange, GenericOpSpec op, IAsmFunctionArchive dst, CaptureEmissionObserver observer)
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
                        OnSave(dst.Save(fGroup, true), observer);
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
                        OnSave(dst.Save(fGroup, true), observer);
                    }
                }
            }
        }

        void EmitDirectImm(in CaptureExchange exchange, DirectOpGroupSpec op, IAsmFunctionArchive dst, CaptureEmissionObserver observer)
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
                observer(tokens.ToGroup(tokens[0].Uri.GroupUri));
        }                    

        DirectOpGroupSpec PrimaryGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => !FunctionType.immneeds(m.Root)));

        DirectOpGroupSpec ImmGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => FunctionType.immneeds(m.Root)));

        IEnumerable<ApiHost> ApiHosts
            => Catalog.DirectApiHosts.Union(Catalog.GenericApiHosts);

        void ClearArchives(bool imm)
        {
            if(imm)
                iter(ApiHosts.Select(HostImmArchive), a => a.Clear());
            else
                iter(ApiHosts.Select(HostArchive), a => a.Clear());
        }    

        void OnSave(Option<CaptureTokenGroup> g, CaptureEmissionObserver observer)
        {
            if(g.IsSome())
            {
                observer(g.Value);            
                foreach(var t in g.Value.Tokens)
                    print(Emitted(t));
            }
        }

        void IPointSink<CaptureTokenGroup>.Accept(in CaptureTokenGroup src)
        {
            Observer(src);
        }

        string ArchiveSubject(ApiHost host, bool imm)
            =>  host.Name + (imm ?  "_imm" : string.Empty);

        IAsmFunctionArchive HostArchive(ApiHost host)
            => Archive(ArchiveSubject(host,false));

        IAsmFunctionArchive HostImmArchive(ApiHost host)
            => Archive(ArchiveSubject(host,true));

        IAsmFunctionArchive Archive(string subject)
            => Context.FunctionArchive(Catalog.AssemblyId, subject);

        AsmFunction Decode(in CaptureExchange exchange, OpIdentity id, MethodInfo method)
            => Decoder.Decode(exchange, id, method);

        static byte[] ImmSelection => new byte[]{5,9,13};
    }
}