//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    using static AsmServiceMessages;

    class AsmCatalogEmitter : IAsmCatalogEmitter
    {
        public static AsmCatalogEmitter Create(IOperationCatalog catalog)
            => new AsmCatalogEmitter(catalog);

        public AsmCatalogEmitter(IOperationCatalog catalog)
        {
            this.Catalog = catalog;
            this.ClrMetadata = ClrMetadataIndex.Create(catalog.DeclaringAssembly);
        }

        readonly ClrMetadataIndex ClrMetadata;

        public IOperationCatalog Catalog {get;}

        static string ImmSubject
            => "_imm";

        void EmitUnaryImmResolutions(DirectOpInfo op, AsmArchive archive)
        {
            print(EmittingImmResolutions(op));                        
            var resolutions = AsmImmCapture.unary(op.Method, op.Id, new byte[]{5,9,13});
            archive.Save(resolutions);
        }   

        void EmitUnaryImmResolutions(GenericOpInfo op, AsmArchive archive)
        {
            print(EmittingImmResolutions(op));
            foreach(var closure in op.Closures())
            {
                var resolutions = AsmImmCapture.unary(closure.ClosedMethod, closure.Id, new byte[]{5,9,13});                
                archive.Save(resolutions);
            }
        }

        void Emit(GenericOpInfo op, AsmArchive archive)
        {
            var closures = op.Closures().ToArray();
            
            if(closures.Length == 0)
                print(NoClosures(op));
            else
                print(Emitting(op));

            foreach(var closure in closures)
            {
                Emitting(closure);
                AsmDecoder.decode(closure.Id, closure.ClosedMethod, ClrMetadata).OnSome(x => archive.Save(x));
            }
        }

        void Emit(DirectOpInfo op, AsmArchive archive)
        {                        
            print(Emitting(op));
            AsmDecoder.decode(op.Id, op.Method, ClrMetadata).OnSome(x => archive.Save(x));
        }

        void EmitGeneric(Type host)
        {
            print(Emitting(host));

            var subject = host.Name.ToLower();
            var archive = AsmArchive.Define(subject);
            archive.Clear();

            var immArchive = AsmArchive.Define(concat(subject, ImmSubject));
            immArchive.Clear();

            var fastops = host.FastOpGenericMethods();
            foreach(var op in fastops)
            {
                if(op.RequiresImmediate())
                {
                    if(op.Method.IsUnaryImmVectorOp())
                        EmitUnaryImmResolutions(op,immArchive);
                }
                else
                    Emit(op,archive);
            }
        }

        void EmitDirect(Type host)
        {
            print(Emitting(host));

            var subject = host.Name.ToLower();
            var archive = AsmArchive.Define(subject);
            archive.Clear();

            var immArchive = AsmArchive.Define(concat(subject, ImmSubject));
            immArchive.Clear();

            var fastops = host.FastOpDirect();            
            foreach(var op in fastops)
            {
                if(op.RequiresImmediate())
                {
                    if(op.Method.IsUnaryImmVectorOp())
                        EmitUnaryImmResolutions(op, immArchive);
                }
                else
                    Emit(op, archive);
            }
        }

        public void EmitDirect()
            => iter(Catalog.DirectApiHosts, host => EmitDirect(host));

        public void EmitGeneric()
            => iter(Catalog.GenericApiHosts, host => EmitGeneric(host));

        public void EmitCatalog()
        {            
            EmitDirect();
            EmitGeneric();
        }        
    }
}