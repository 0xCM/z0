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

    using Z0.AsmSpecs;

    using static zfunc;

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
                        
        IEnumerable<AsmEmissionToken> EmitImm(GenericOpSpec op, IAsmFunctionArchive dst)
        {
            if(FunctionType.vunaryImm(op.Root))
            {                                                
                var resolutions = op.Close()
                    .Select(closure => Context.ImmCapture(closure.ClosedMethod, closure.Id, n1))
                    .SelectMany(svc => svc.Capture(ImmSelection)).ToArray();                

                if(resolutions.Length != 0)
                    foreach(var token in dst.Save(AsmFunctionGroup.Define(op.Id, resolutions),true))
                        yield return token;
            }
            else if(FunctionType.vbinaryImm(op.Root))
            {
                var resolutions = op.Close()
                    .Select(closure => Context.ImmCapture(closure.ClosedMethod, closure.Id,n2))
                    .SelectMany(svc => svc.Capture(ImmSelection)).ToArray();                

                if(resolutions.Length != 0)
                    foreach(var token in dst.Save(AsmFunctionGroup.Define(op.Id, resolutions),true))
                        yield return token;
            }
        }

        IEnumerable<AsmEmissionToken> EmitImm(DirectOpGroupSpec op, IAsmFunctionArchive dst)
        {
            foreach(var member in op.Members.Where(m => FunctionType.vunaryImm(m.Root)))
            {
                var resolutions = Context.ImmCapture(member.Root, member.Id,n1).Capture(ImmSelection);
                var group = AsmFunctionGroup.Define(op.Id, resolutions.ToArray());
                foreach(var r in dst.Save(group,true))
                    yield return r;                
            }

            foreach(var member in op.Members.Where(m => FunctionType.vbinaryImm(m.Root)))
            {
                var resolutions = Context.ImmCapture(member.Root, member.Id,n2).Capture(ImmSelection);
                var group = AsmFunctionGroup.Define(op.Id, resolutions.ToArray());
                foreach(var r in dst.Save(group,true))
                    yield return r;                
            }
        }                    

        AsmFunction Decode(OpIdentity id, MethodInfo method)
            => Decoder.DecodeFunction(id, method);            

        IEnumerable<AsmEmissionToken> Emit(DirectOpGroupSpec group, IAsmFunctionArchive dst)
        {
            var functions = group.Members.Map(m => Decode(m.Id, m.Root));
            if(functions.Length != 0)            
                foreach(var token in dst.Save(AsmFunctionGroup.Define(group.Id, functions),true))
                    yield return token;            
        }

        IEnumerable<AsmEmissionToken> Emit(GenericOpSpec op, IAsmFunctionArchive dst)
        {
            var functions = op.Close().Map(closure => Decoder.DecodeFunction(closure.Id, closure.ClosedMethod));
            if(functions.Length != 0)
            {
                foreach(var token in dst.Save(AsmFunctionGroup.Define(op.Id, functions),true))
                    yield return token;
            }            
        }

        IEnumerable<AsmEmissionToken> Emit(GenericOpSpec op, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => FunctionType.immneeds(op.Root) ? EmitImm(op,immediate) : Emit(op,primary);

        DirectOpGroupSpec PrimaryGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => !FunctionType.immneeds(m.Root)));

        DirectOpGroupSpec ImmGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => FunctionType.immneeds(m.Root)));

        IEnumerable<AsmEmissionToken> Emit(DirectOpGroupSpec g, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => Emit(PrimaryGroup(g),primary).Union(EmitImm(ImmGroup(g),immediate));

        string ArchiveSubject(Type host, bool imm)
            =>  host.HostName() + (imm ?  "_imm" : string.Empty);

        Pair<IAsmFunctionArchive> HostArchives(Type host)
            => pair(Archive(ArchiveSubject(host,false)),Archive(ArchiveSubject(host,true)));

        IEnumerable<AsmEmissionToken> EmitGeneric(Type host, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => from op in OpSpecs.Generic.FromHost(host)
               from emission in Emit(op, primary, immediate)
                select emission;

        IEnumerable<AsmEmissionToken> EmitDirect(Type host, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => from g in OpSpecs.DirectGroups.FromHost(host)
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