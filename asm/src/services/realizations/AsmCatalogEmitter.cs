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

    using static zfunc;
    using static AsmServiceMessages;

    class AsmCatalogEmitter : IAsmCatalogEmitter
    {
        public static AsmCatalogEmitter Create(IOperationCatalog catalog)
            => new AsmCatalogEmitter(catalog);

        AsmCatalogEmitter(IOperationCatalog catalog)
        {
            this.Catalog = catalog;
            this.ClrMetadata = ClrMetadataIndex.Create(catalog.DeclaringAssembly);
            this.Decoder = AsmServices.Decoder(ClrMetadata, 12*1024);
        }

        readonly ClrMetadataIndex ClrMetadata;

        public IOperationCatalog Catalog {get;}

        public IAsmDecoder Decoder {get;}

        ref readonly AsmDescriptor Pipe(in AsmDescriptor src, bool warn = false)
        {
            print(Emitted(src));            
            return ref src;
        }

        IAsmFunctionArchive Archive(string subject)
            => AsmServices.FunctionArchive(Catalog.CatalogName, subject);

        static ReadOnlySpan<byte> ImmSelection => new byte[]{5,9,13};

        IEnumerable<AsmDescriptor> EmitUnaryImmResolutions(DirectOpSpec op, IAsmFunctionArchive dst)
            => from capture in AsmImmCapture.UnaryFunctions(op.Method, op.Id, ImmSelection.ToArray())
                select dst.Save(capture);

        IEnumerable<AsmDescriptor> EmitUnaryImmResolutions(GenericOpSpec op, IAsmFunctionArchive dst)
            => from closure in OpFactory.close(op)
                from capture in AsmImmCapture.UnaryFunctions(closure.ClosedMethod, closure.Id, ImmSelection.ToArray())
                select dst.Save(capture);
        

        IEnumerable<AsmDescriptor> ResolveImmediates(GenericOpSpec op, IAsmFunctionArchive dst)
        {
            if(FunctionType.vunaryImm(op.Method))
            {
                foreach(var emitted in EmitUnaryImmResolutions(op,dst))
                    yield return emitted;
            }                        
        }

        IEnumerable<AsmDescriptor> ResolveImmediates(DirectOpSpec op, IAsmFunctionArchive dst)
        {
            if(FunctionType.vunaryImm(op.Method))
            {
                foreach(var emitted in EmitUnaryImmResolutions(op,dst))
                    yield return emitted;
            }                        
        }

        IEnumerable<AsmDescriptor> Emit(DirectOpSpec op, IAsmFunctionArchive archive)
            => items(archive.Save(Decoder.Decode(op.Id, op.Method)));


        IEnumerable<AsmDescriptor> Emit(GenericOpSpec op, IAsmFunctionArchive archive)
            => OpFactory.close(op).Select(closure => archive.Save(Decoder.Decode(closure.Id, closure.ClosedMethod)));

        IEnumerable<AsmDescriptor> Emit2(DirectOpSpec op, IAsmFunctionArchive archive)
            => items(archive.Save(Decoder.DecodeFunction(op.Id, op.Method)));

        IEnumerable<AsmDescriptor> Emit2(GenericOpSpec op, IAsmFunctionArchive archive)
            => OpFactory.close(op).Select(closure => archive.Save(Decoder.DecodeFunction(closure.Id, closure.ClosedMethod)));

        IEnumerable<AsmDescriptor> Emit(DirectOpSpec op, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => FunctionType.immneeds(op.Method) ? ResolveImmediates(op,immediate) : Emit2(op,primary);

        IEnumerable<AsmDescriptor> Emit(GenericOpSpec op, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => FunctionType.immneeds(op.Method) ? ResolveImmediates(op,immediate) : Emit2(op,primary);

        string ArchiveSubject(Type host, bool imm)
            => imm ? concat(host.Name.ToLower(), "_imm") : host.Name.ToLower();

        Pair<IAsmFunctionArchive> OpenHostArchives(Type host)
        {
            var primary = Archive(ArchiveSubject(host,false)).Clear();
            var immediate = Archive(ArchiveSubject(host,true)).Clear();
            return pair(primary,immediate);
        }

        IEnumerable<AsmDescriptor> EmitGeneric(Type host, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => from op in OpSpecs.generic(host)
               from emission in Emit(op,primary, immediate)
                select emission;

        IEnumerable<AsmDescriptor> EmitDirect(Type host, IAsmFunctionArchive primary, IAsmFunctionArchive immediate)
            => from op in OpSpecs.direct(host)
               from emission in Emit(op,primary, immediate)
                select emission;

        IEnumerable<AsmDescriptor> EmitGeneric(Type host)
        {
            (var primary, var immediate) = OpenHostArchives(host);
            return EmitGeneric(host,primary,immediate);
        }
        
        IEnumerable<AsmDescriptor> EmitDirect(Type host)
        {
            (var primary, var immediate) = OpenHostArchives(host);            
            return EmitDirect(host,primary,immediate);
        }

        public IEnumerable<AsmDescriptor> EmitDirect()
            => from h in Catalog.DirectApiHosts
              from emission in EmitDirect(h)
              select Pipe(emission);

        public IEnumerable<AsmDescriptor> EmitGeneric()
            => from h in Catalog.GenericApiHosts
                from emission in EmitGeneric(h)
                    select Pipe(emission);
        
        public IEnumerable<AsmDescriptor> EmitCatalog()
            => EmitDirect().Union(EmitGeneric());
    }
}