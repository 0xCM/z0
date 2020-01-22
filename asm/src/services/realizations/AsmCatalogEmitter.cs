//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

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
            this.Decoder = AsmServices.Decoder(ClrMetadata);
        }

        readonly ClrMetadataIndex ClrMetadata;

        public IOperationCatalog Catalog {get;}

        public IAsmDecoder Decoder {get;}

        static string ImmSubject
            => "_imm";

        ref readonly AsmDescriptor Pipe(in AsmDescriptor src)
        {
            print(Emitted(src));
            return ref src;
        }

        IAsmFunctionArchive Archive(string subject)
            => AsmServices.FunctionArchive(Catalog.CatalogName, subject);

        IEnumerable<AsmDescriptor> EmitUnaryImmResolutions(DirectOpInfo op, IAsmFunctionArchive archive)
        {
            var immediates = new byte[]{5,9,13};
            var captured  =  AsmImmCapture.UnaryFunctions(op.Method, op.Id, immediates);                    
            return archive.Save(captured);            
        }   

        IEnumerable<AsmDescriptor> EmitUnaryImmResolutions(GenericOpInfo op, IAsmFunctionArchive archive)
        {
            var immediates = new byte[]{5,9,13};
            foreach(var closure in op.Closures().ToArray())
            foreach(var descriptor in archive.Save(AsmImmCapture.UnaryFunctions(closure.ClosedMethod, closure.Id, immediates)))
                yield return descriptor;
        }

        IEnumerable<AsmDescriptor> Emit(GenericOpInfo op, IAsmFunctionArchive archive)
        {
            var closures = op.Closures().ToArray();
            
            if(closures.Length == 0)
                print(NoClosures(op));
            
            foreach(var closure in closures)
                yield return archive.Save(Decoder.DecodeFunction(closure.Id, closure.ClosedMethod));
        }

        IEnumerable<AsmDescriptor> Emit(DirectOpInfo op, IAsmFunctionArchive archive)
        {                        
            yield return archive.Save(Decoder.DecodeFunction(op.Id, op.Method));
        }

        IEnumerable<AsmDescriptor> EmitGeneric(Type host)
        {
            var subject = host.Name.ToLower();
            var archive = Archive(subject);
            archive.Clear();

            var immArchive = Archive(concat(subject, ImmSubject));
            immArchive.Clear();

            foreach(var op in host.FastOpGenericMethods())
            {
                if(op.RequiresImmediate())
                {
                    if(op.Method.IsUnaryImmVectorOp())
                    {
                        foreach(var emitted in EmitUnaryImmResolutions(op,immArchive))
                            yield return emitted;
                    }                        
                }
                else
                {
                    foreach(var emitted in Emit(op,archive))
                        yield return emitted;
                }
            }
        }

        IEnumerable<AsmDescriptor> EmitDirect(Type host)
        {
            var subject = host.Name.ToLower();
            var archive = Archive(subject);
            archive.Clear();

            var immArchive = Archive(concat(subject, ImmSubject));
            immArchive.Clear();

            foreach(var op in host.FastOpDirect())
            {
                if(op.RequiresImmediate())
                {
                    if(op.Method.IsUnaryImmVectorOp())
                    {
                        foreach(var emitted in EmitUnaryImmResolutions(op, immArchive))
                            yield return emitted;
                    }
                }
                else
                {
                    foreach(var emitted in Emit(op,archive))
                        yield return emitted;
                }
            }
        }

        public IEnumerable<AsmDescriptor> EmitDirect()
        {
            foreach(var h in Catalog.DirectApiHosts)
            foreach(var emitted in EmitDirect(h))    
                yield return Pipe(emitted);
        }

        public IEnumerable<AsmDescriptor> EmitGeneric()
        {
            foreach(var h in Catalog.GenericApiHosts)
            foreach(var emitted in EmitGeneric(h))    
                yield return Pipe(emitted);            
        }

        public IEnumerable<AsmDescriptor> EmitCatalog()
        {                        
            foreach(var emitted in EmitDirect())
                yield return emitted;
            
            foreach(var emitted in EmitGeneric())
                yield return emitted;
        }        
    }
}