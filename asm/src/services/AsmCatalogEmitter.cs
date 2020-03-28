//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static root;
    using static AsmServiceMessages;

    class AsmCatalogEmitter : IAsmCatalogEmitter
    {
        public IAsmContext Context {get;}

        readonly IApiCatalog Catalog;

        readonly IAsmFunctionDecoder Decoder;

        readonly AsmEmissionObserver Observer;

        [MethodImpl(Inline)]
        public static IAsmCatalogEmitter Create(IAsmContext context, IApiCatalog catalog, AsmEmissionObserver observer)
            => new AsmCatalogEmitter(context,catalog,observer);

        [MethodImpl(Inline)]
        AsmCatalogEmitter(IAsmContext context, IApiCatalog catalog, AsmEmissionObserver observer)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Decoder = Context.AsmFunctionDecoder();
            this.Observer = observer;
        }

        IAsmFunctionArchive Archive(ApiHostUri host, bool imm)
            => Context.FunctionArchive(host, imm);

        IAsmCatalogEmitter Me
        {
            [MethodImpl(Inline)]
            get => this;
        }
        
        void IAsmCatalogEmitter.EmitPrimary(in OpExtractExchange exchange, AsmEmissionObserver observer)
        {
            ClearArchives(false);
            EmitDirectPrimary(exchange,observer);
            EmitGenericPrimary(exchange,observer);
        }

        void IAsmCatalogEmitter.EmitImm(in OpExtractExchange exchange, AsmEmissionObserver observer)
        {
            ClearArchives(true);
            EmitDirectImm(exchange,observer);
            EmitGenericImm(exchange,observer);
        }

        void EmitDirectPrimary(in OpExtractExchange exchange, AsmEmissionObserver observer)
        {            
            foreach(var host in Catalog.DirectApiHosts)
                EmitDirectPrimary(exchange, host, observer);
        }

        void EmitDirectImm(in OpExtractExchange exchange, AsmEmissionObserver observer)
        {
            foreach(var host in Catalog.DirectApiHosts)
            {
                var archive = HostImmArchive(host);
                var specs = from g in  Context.OpCollector().CollectDirect(host)
                             let immg = ImmGroup(host,g)
                             where !immg.IsEmpty
                             select immg;
                
                foreach(var g in specs)
                    EmitDirectImm(exchange, g, archive, observer);
            }
        }

        void EmitGenericPrimary(in OpExtractExchange exchange, AsmEmissionObserver observer)
        {
            foreach(var host in Catalog.GenericApiHosts)                
                EmitGenericPrimary(exchange, host, observer);
        }

        void EmitGenericImm(in OpExtractExchange exchange, AsmEmissionObserver observer)
        {        
            foreach(var host in Catalog.GenericApiHosts)
            {
                var archive = HostImmArchive(host);
                var specs = Context.OpCollector().CollectGeneric(host).Where(op => op.Method.AcceptsImmediate());

                foreach(var spec in specs)
                    EmitGenericImm(exchange, spec, archive, observer);                
            }        
        }

        void EmitDirectPrimary(in OpExtractExchange exchange, ApiHost host, AsmEmissionObserver observer)
        {
            var primary = HostArchive(host);
            var specs =  Context.OpCollector().CollectDirect(host);

            foreach(var spec in specs)
                Emit(exchange, PrimaryGroup(host,spec), primary, observer);
        }

        void EmitGenericPrimary(in OpExtractExchange exchange, ApiHost host, AsmEmissionObserver observer)
        {
            var primary = HostArchive(host);            
            var specs = Context.OpCollector().CollectGeneric(host);

            foreach(var spec in specs.Where(spec => !spec.Method.AcceptsImmediate()))
                Emit(exchange, spec, primary, observer);
        }        

        void Emit(in OpExtractExchange exchange, DirectApiGroup group, IAsmFunctionArchive dst, AsmEmissionObserver observer)
        {                                    
            var functions = new List<AsmFunction>();
            foreach(var spec in group.Members)
                functions.Add(Decode(Decoder, exchange, spec));
            
            if(functions.Count != 0)
            {
                var fGroup = AsmFunctionGroup.Define(group.GroupId, functions.ToArray());
                OnSave(dst.Save(fGroup, true), observer);
            }                        
        }

        AsmFunction Decode(IAsmFunctionDecoder decoder, in OpExtractExchange exchange, DirectApiOp src)
            => decoder.DecodeFunction(Context.Capture().Capture(in exchange, src.Id, src.Method));

        AsmFunction Decode(IAsmFunctionDecoder decoder, in OpExtractExchange exchange, ClosedApiOp closure)
            => decoder.DecodeFunction(Context.Capture().Capture(in exchange, closure.Id, closure.Method));

        void Emit(in OpExtractExchange exchange, GenericApiOp op, IAsmFunctionArchive dst, AsmEmissionObserver observer)
        {
            var functions = new List<AsmFunction>();
            foreach(var closure in op.Close())                        
                functions.Add(Decode(Decoder, in exchange, closure));
            if(functions.Count != 0)
            {
                var fGroup = AsmFunctionGroup.Define(op.GenericId, functions.ToArray());
                OnSave(dst.Save(fGroup, true), observer);
            }
        }

        void EmitGenericImm(in OpExtractExchange exchange, GenericApiOp op, IAsmFunctionArchive dst, AsmEmissionObserver observer)
        {
            if(op.Method.IsVectorizedUnaryImm())
            {                                                
                foreach(var closure in op.Close())
                {
                    var svc = Context.ImmUnaryCapture(closure.Method, closure.Id);
                    var functions = svc.Capture(in exchange, ImmSelection);
                    if(functions.Length != 0)
                    {
                        var fGroup = AsmFunctionGroup.Define(op.GenericId, functions);
                        OnSave(dst.Save(fGroup, true), observer);
                    }
                }
            }
            else if(op.Method.IsVectorizedBinaryImm())
            {
                foreach(var closure in op.Close())
                {
                    var svc = Context.ImmBinaryCapture(closure.Method, closure.Id);
                    var functions = svc.Capture(in exchange, ImmSelection);
                    if(functions.Length != 0)
                    {
                        var fGroup = AsmFunctionGroup.Define(op.GenericId, functions);
                        OnSave(dst.Save(fGroup, true), observer);
                    }
                }
            }
        }

        void EmitDirectImm(in OpExtractExchange exchange, DirectApiGroup op, IAsmFunctionArchive dst, AsmEmissionObserver observer)
        {
            var tokens = new List<AsmEmissionToken>();
            foreach(var member in op.Members.Where(m => m.Method.IsVectorizedUnaryImm()))
            {
                var resolutions = Context.ImmUnaryCapture(member.Method, member.Id).Capture(in exchange, ImmSelection);
                if(resolutions.Length != 0)
                {
                    var fGroup = AsmFunctionGroup.Define(op.GroupId, resolutions.ToArray());
                    var tGroup = dst.Save(fGroup, true);
                    tGroup.OnSome(t => tokens.AddRange(t.Content)).OnSome(g => Me.Accept(g));
                }
            }

            foreach(var member in op.Members.Where(m => m.Method.IsVectorizedBinaryImm()))
            {
                var resolutions = Context.ImmBinaryCapture(member.Method, member.Id).Capture(in exchange, ImmSelection);
                if(resolutions.Length != 0)
                {
                    var fGroup = AsmFunctionGroup.Define(op.GroupId, resolutions.ToArray());
                    var tGroup = dst.Save(fGroup, true);
                    tGroup.OnSome(t => tokens.AddRange(t.Content)).OnSome(g => Me.Accept(g));
                }
            }

            if(tokens.Count != 0)
                observer(AsmEmissionTokens.From(tokens[0].Uri.GroupUri,tokens));
        }                    

        DirectApiGroup PrimaryGroup(ApiHost host, DirectApiGroup g)
            => DirectApiGroup.Define(host, g.GroupId, g.Members.Where(m => !m.Method.AcceptsImmediate()));

        DirectApiGroup ImmGroup(ApiHost host, DirectApiGroup g)
            => DirectApiGroup.Define(host, g.GroupId, g.Members.Where(m => m.Method.AcceptsImmediate()));

        IEnumerable<ApiHost> ApiHosts
            => Catalog.DirectApiHosts.Union(Catalog.GenericApiHosts);

        void ClearArchives(bool imm)
        {
            if(imm)
                iter(ApiHosts.Select(HostImmArchive), a => a.Clear());
            else
                iter(ApiHosts.Select(HostArchive), a => a.Clear());
        }    

        void OnSave(Option<AsmEmissionTokens<OpUri>> g, AsmEmissionObserver observer)
        {
            if(g.IsSome())
            {
                observer(g.Value);            
                foreach(var t in g.Value.Content)
                    term.inform(Emitted(t));
            }
        }

        void ISink<AsmEmissionTokens<OpUri>>.Accept(in AsmEmissionTokens<OpUri> src)
        {
            Observer(src);
        }

        string ArchiveSubject(ApiHost host, bool imm)
            =>  host.HostName + (imm ?  "_imm" : string.Empty);

        IAsmFunctionArchive HostArchive(ApiHost host)
            => Archive(ArchiveSubject(host,false));

        IAsmFunctionArchive HostImmArchive(ApiHost host)
            => Archive(ArchiveSubject(host,true));

        IAsmFunctionArchive Archive(string subject)
            => Context.FunctionArchive(Catalog.PartId, subject);

        static byte[] ImmSelection => new byte[]{5,9,13};
    }
}