//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;
    using static AsmServiceMessages;

    class AsmCatalogEmitter : IAsmCatalogEmitter
    {
        public static AsmCatalogEmitter Create(IAsmContext context, IOperationCatalog catalog)
            => new AsmCatalogEmitter(context,catalog);

        AsmCatalogEmitter(IAsmContext context, IOperationCatalog catalog)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Decoder = Context.Decoder();
        }

        public IAsmContext Context {get;}

        readonly IOperationCatalog Catalog;

        readonly IAsmDecoder Decoder;

        IEnumerable<AsmEmissionToken> EmitDirect()
            => from h in Catalog.DirectApiHosts
               from emission in EmitDirect(h)
               select Emitted(emission);

        IEnumerable<AsmEmissionToken> EmitGeneric()
            => from h in Catalog.GenericApiHosts
               from emission in EmitGeneric(h)
               select Emitted(emission);
        void ClearArchives()
        {
            var hosts = Catalog.DirectApiHosts.Union(Catalog.GenericApiHosts);
            foreach(var (a1,a2) in hosts.Select(h => HostArchives(h)))
            {
                a1.Clear();
                a2.Clear();
            }
        }

        public IEnumerable<AsmEmissionToken> EmitCatalog()
        {
            ClearArchives();
            return EmitDirect().Union(EmitGeneric());
        }

        ref readonly AsmEmissionToken Emitted(in AsmEmissionToken src)
        {
            print(AsmServiceMessages.Emitted(src));            
            return ref src;
        }
                        
        GenericOpSpec ImmPrecapture(GenericOpSpec op)
            => op;

       IAsmImmCapture ImmCaptureSvc(MethodInfo src, Moniker baseid)
            => Context.UnaryImmCapture(src, baseid);

        IEnumerable<AsmFunction> ResolveImmediates(GenericOpSpec op)                        
            => OpSpecs.close(ImmPrecapture(op))
                .Select(closure =>  ImmCaptureSvc(closure.ClosedMethod, closure.Id))
                .SelectMany(svc => svc.Capture(ImmSelection));

        IEnumerable<AsmFunction> ResolveImmediates(DirectOpGroup g)
            => from op in g.Members
                where FunctionType.vunaryImm(op.Method)
                from f in ImmCaptureSvc(op.Method, op.Id).Capture(ImmSelection) 
                select f;
        IEnumerable<AsmEmissionToken> SaveImmResolutions(GenericOpSpec op, IAsmFunctionArchive dst)
        {
            if(FunctionType.vunaryImm(op.Method))
            {
                
                var resolutions = ResolveImmediates(op).ToArray();                
                if(resolutions.Length != 0)
                    foreach(var token in dst.Save(AsmFunctionGroup.Define(op.Id, resolutions),true))
                        yield return token;
            }
        }

        IEnumerable<AsmEmissionToken> SaveImmResolutions(DirectOpGroup g, IAsmFunctionArchive dst)
        {
            var resolutions = ResolveImmediates(g).ToArray();
            return resolutions.Length != 0 
                ? dst.Save(AsmFunctionGroup.Define(g.Id, resolutions),true) 
                : items<AsmEmissionToken>();
        }

        AsmFunction Decode(Moniker id, MethodInfo method)
            => Decoder.DecodeFunction(id, method);            

        IEnumerable<AsmEmissionToken> Emit(DirectOpSpec op, IAsmFunctionArchive dst)
            => items(dst.Save(Decode(op.Id, op.Method)));

        IEnumerable<AsmEmissionToken> Emit(DirectOpGroup group, IAsmFunctionArchive dst)
        {
            var functions = group.Members.Map(m => Decode(m.Id, m.Method));
            if(functions.Length != 0)
                foreach(var token in dst.Save(AsmFunctionGroup.Define(group.Id, functions),true))
                    yield return token;            
        }

        IEnumerable<AsmEmissionToken> Emit(GenericOpSpec op, IAsmFunctionArchive dst)
        {
            var functions = OpSpecs.close(op).Map(closure => Decoder.DecodeFunction(closure.Id, closure.ClosedMethod));
            if(functions.Length != 0)
            {
                foreach(var token in dst.Save(AsmFunctionGroup.Define(op.Id, functions),true))
                    yield return token;
            }            
        }

        IEnumerable<AsmEmissionToken> Emit(GenericOpSpec op, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => FunctionType.immneeds(op.Method) ? SaveImmResolutions(op,immediate) : Emit(op,primary);

        IEnumerable<AsmEmissionToken> Emit(DirectOpGroup g, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => g.Members.Any(m => FunctionType.immneeds(m.Method)) ? SaveImmResolutions(g,immediate) : Emit(g,primary);

        string ArchiveSubject(Type host, bool imm)
            =>  host.HostName() + (imm ?  "_imm" : string.Empty);

        Pair<IAsmFunctionArchive> HostArchives(Type host)
            => pair(Archive(ArchiveSubject(host,false)),Archive(ArchiveSubject(host,true)));

        IEnumerable<AsmEmissionToken> EmitGeneric(Type host, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => from op in OpSpecs.generic(host)
               from emission in Emit(op, primary, immediate)
                select emission;

        IEnumerable<AsmEmissionToken> EmitDirect(Type host, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => from g in OpSpecs.directGroups(host)
               from emission in Emit(g, primary, immediate)
                select emission;

        IEnumerable<AsmEmissionToken> EmitGeneric(Type host)
        {
            (var primary, var immediate) = HostArchives(host);
            return EmitGeneric(host,primary,immediate);
        }
        
        IEnumerable<AsmEmissionToken> EmitDirect(Type host)
        {
            (var primary, var immediate) = HostArchives(host);            
            return EmitDirect(host, primary, immediate);
        }

        IAsmFunctionArchive Archive(string subject)
            => Context.FunctionArchive(Catalog.CatalogName, subject);

        static byte[] ImmSelection => new byte[]{5,9,13};

 

    }
}