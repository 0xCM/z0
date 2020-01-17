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

    public interface IAsmCatalogEmitter
    {
       void EmitCatalog();
       
       void EmitDirect();
       
       void EmitGeneric();
         
    }

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

        void EmitUnaryImmResolutions(FastDirectInfo op, AsmArchive archive)
        {
            print(EmittingImmediateResolutions(op));                        
            archive.Save(AsmImmCapture.unary(op.Method, op.Id, new byte[]{5,9,13}).Select(x => x.Encoded));
        }   

        void EmitUnaryImmResolutions(FastGenericInfo op, AsmArchive archive)
        {
            print(EmittingImmediateResolutions(op));
            foreach(var (moniker, method) in op.Closures())
                archive.Save(AsmImmCapture.unary( method,moniker, new byte[]{5,9,13}).Select(x => x.Encoded));
        }

        void Emit(FastGenericInfo op, AsmArchive archive)
        {
            var closures = op.Closures().ToArray();
            
            if(closures.Length == 0)
                print(NoClosures(op));
            else
                print(EmittingOp(op));

            foreach(var (moniker, method) in closures)
            {
                AsmDecoder.decode(method, moniker, ClrMetadata).OnSome(x => archive.Save(x.AsmCode, x.CilFunction.ValueOrDefault()));
            }
        }

        void Emit(FastDirectInfo op, AsmArchive archive)
        {                        
            print(EmittingOp(op));
            AsmDecoder.decode(op.Method, op.Id, ClrMetadata).OnSome(x => archive.Save(x.AsmCode, x.CilFunction.ValueOrDefault()));
        }

        void EmitGeneric(Type host)
        {
            print(EmittingHostOps(host));

            var subject = host.Name.ToLower();
            var archive = AsmArchive.Define(subject);
            archive.Clear();

            var immArchive = AsmArchive.Define(concat(subject, ImmSubject));
            immArchive.Clear();

            var fastops = host.FastOpGenerics();
            foreach(var op in fastops)
            {
                if(op.RequiresImmediate)
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
            print(EmittingHostOps(host));

            var subject = host.Name.ToLower();
            var archive = AsmArchive.Define(subject);
            archive.Clear();

            var immArchive = AsmArchive.Define(concat(subject, ImmSubject));
            immArchive.Clear();

            var fastops = host.FastOpDirect();            
            foreach(var op in fastops)
            {
                if(op.RequiresImmediate)
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