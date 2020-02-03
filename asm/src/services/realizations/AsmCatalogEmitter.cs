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
        public static IAsmCatalogEmitter Create(IAsmContext context, IOperationCatalog catalog)
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

        IEnumerable<AsmEmissionToken> EmitDirectImm()
            => from h in Catalog.DirectApiHosts
               let archive = HostImmArchive(h)
               from g in OpSpecs.DirectGroups.FromHost(h)
               let immg = ImmGroup(g)
               where !immg.IsEmpty
               from emission in EmitImm(immg,archive)
               select emission;

        IEnumerable<AsmEmissionToken> EmitGenericImm()
            => from h in Catalog.GenericApiHosts
               let archive = HostImmArchive(h)
               from op in OpSpecs.Generic.FromHost(h)
               where FunctionType.immneeds(op.Root)
               from emission in EmitImm(op,archive)
               select emission;

        IEnumerable<AsmEmissionToken> EmitDirectPrimary()
            => from h in Catalog.DirectApiHosts
               from emission in EmitDirect(h,false)
               select Emitted(emission);

        IEnumerable<AsmEmissionToken> EmitGenericPrimary()
            => from h in Catalog.GenericApiHosts
               from emission in EmitGeneric(h,false)
               select Emitted(emission);

        
        IEnumerable<Type> ApiHosts
            => Catalog.DirectApiHosts.Union(Catalog.GenericApiHosts);

        void ClearArchives(bool imm)
        {
            if(imm)
                iter(ApiHosts.Select(HostImmArchive), a => a.Clear());
            else
                iter(ApiHosts.Select(HostArchive), a => a.Clear());
        }    

        public IEnumerable<AsmEmissionToken> EmitImm()
        {
            ClearArchives(true);
            return EmitDirectImm().Union(EmitGenericImm());
        }

        public IEnumerable<AsmEmissionToken> EmitPrimary()
        {
            ClearArchives(false);
            return EmitDirectPrimary().Union(EmitGenericPrimary());
        }

        // public IEnumerable<AsmEmissionToken> EmitCatalog()
        // {
        //     var primary = EmitPrimary();
        //     var imm = EmitImm();
        //     return primary.Union(imm);
        // }


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

        DirectOpGroupSpec PrimaryGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => !FunctionType.immneeds(m.Root)));

        DirectOpGroupSpec ImmGroup(DirectOpGroupSpec g)
            => DirectOpGroupSpec.Define(g.Id, g.Members.Where(m => FunctionType.immneeds(m.Root)));

        IEnumerable<AsmEmissionToken> EmitDirect(Type host, bool imm)
        {
            var primary = HostArchive(host);
            var immediate = HostImmArchive(host);
            var specs = OpSpecs.DirectGroups.FromHost(host);

            var ePrimary =
                from spec in specs
                from token in Emit(PrimaryGroup(spec), primary)
                select token;

            var eImm =
                from spec in specs
                from token in EmitImm(ImmGroup(spec), immediate)
                select token;

            return !imm ? ePrimary : ePrimary.Union(eImm);
        }

        IEnumerable<AsmEmissionToken> EmitGeneric(Type host, bool imm)
        {
            var primary = HostArchive(host);
            var immediate = HostImmArchive(host);
            var specs = OpSpecs.Generic.FromHost(host);

            var ePrimary = 
                from spec in specs
                where !FunctionType.immneeds(spec.Root)
                from token in Emit(spec, primary)
                select token;

            var eImm =
                from spec in specs
                where FunctionType.immneeds(spec.Root)
                from token in EmitImm(spec, immediate)
                select token;

            return !imm ? ePrimary : ePrimary.Union(eImm);
        }        

        ref readonly AsmEmissionToken Emitted(in AsmEmissionToken src)
        {
            print(AsmServiceMessages.Emitted(src));            
            return ref src;
        }

        string ArchiveSubject(Type host, bool imm)
            =>  host.HostName() + (imm ?  "_imm" : string.Empty);

        IAsmFunctionArchive HostArchive(Type host)
            => Archive(ArchiveSubject(host,false));

        IAsmFunctionArchive HostImmArchive(Type host)
            => Archive(ArchiveSubject(host,true));

        IAsmFunctionArchive Archive(string subject)
            => Context.FunctionArchive(Catalog.CatalogName, subject);

        AsmFunction Decode(OpIdentity id, MethodInfo method)
            => Decoder.DecodeFunction(id, method);            

        static byte[] ImmSelection => new byte[]{5,9,13};
    }
}