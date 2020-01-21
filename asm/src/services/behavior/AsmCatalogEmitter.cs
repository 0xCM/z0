//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

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
            archive.Save(AsmImmCapture.unary(op.Method, op.Id, new byte[]{5,9,13}));
        }   

        void EmitUnaryImmResolutions(GenericOpInfo op, AsmArchive archive, bool pll)
        {
            print(EmittingImmResolutions(op));

            foreach(var closure in op.Closures().ToArray())
                archive.Save(AsmImmCapture.unary(closure.ClosedMethod, closure.Id, new byte[]{5,9,13}));
        }

        void Emit(GenericOpInfo op, AsmArchive archive, bool pll)
        {
            var closures = op.Closures().ToArray();
            
            if(closures.Length == 0)
                print(NoClosures(op));
            else
                print(Emitting(op));

            foreach(var closure in closures)
                AsmDecoder.method(closure.Id, closure.ClosedMethod, ClrMetadata).OnSome(x => archive.Save(x));
        }

        void Emit(DirectOpInfo op, AsmArchive archive)
        {                        
            print(Emitting(op));
            AsmDecoder.method(op.Id, op.Method, ClrMetadata).OnSome(x => archive.Save(x));
        }

        AsmArchive Archive(string subject)
            => AsmArchive.Define(Catalog, subject);

        void EmitGeneric(Type host, bool pll)
        {
            print(Emitting(host));

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
                        EmitUnaryImmResolutions(op,immArchive,pll);
                }
                else
                    Emit(op,archive,pll);
            }
        }

        void EmitDirect(Type host, bool pll)
        {
            print(Emitting(host));

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
                        EmitUnaryImmResolutions(op, immArchive);
                }
                else
                    Emit(op, archive);
            }
        }

        public void EmitDirect(bool pll)
            => iter(Catalog.DirectApiHosts, host => EmitDirect(host,pll));

        public void EmitGeneric(bool pll)
            => iter(Catalog.GenericApiHosts, host => EmitGeneric(host,pll));

        public void EmitCatalog(bool pll)
        {            
            EmitDirect(pll);
            EmitGeneric(pll);
        }        
    }
}