//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    class ArchiveControl : Controller<ArchiveControl>
    {        

        static void EmittingHostOps(Type host)
            => print(ControlMessages.EmittingHostOps(host));

        // public AsmCodeSet GetCode(Moniker id, DynamicDelegate f)
        // {

        //     AsmBuffer.Clear();
        //     return NativeReader.read(f, AsmBuffer).CodeSet(id, f.CilFunc());
        // }


        void Append(string subject, params AsmCodeSet[] ops)
        {
            var archive = AsmArchive.Define(subject);
            for(var i=0; i<ops.Length; i++)
                archive.Save(ops[i]);
        }
        

        string ImmSubject
            => nameof(ginx) + "_imm";

        void ResolveDynamic<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var imm = new byte[]{199,205};
            var r1 = VX.vbsll(w,t).EmbedImmediates(imm);
            var r2 = VX.vsrl(w,t).EmbedImmediates(imm);            
            var r3 = VX.vblend8x16(w,t).EmbedImmediates(imm);
            var resolutions = r1.Union(r2).Union(r3).ToArray();
            Append(ImmSubject, resolutions);
        }

        void ResolveDynamic<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var imm = new byte[]{199,205};
            var r1 = VX.vbsll(w,t).EmbedImmediates(imm);
            var r2 = VX.vsrl(w,t).EmbedImmediates(imm);
            var resolutions = r1.Union(r2).ToArray();
            Append(ImmSubject, resolutions);
        }

        void LogError(string opname, Exception e)
            => error(concat(opname,AsciSym.Colon,e.ToString()));

        void Emit(FastDirectOp op, CilMetadataIndex metadata, AsmArchive archive)
        {
            try
            {
                var method = op.Method;
                archive.Save(method.Descriptor(), metadata.FindCil(method).ValueOrDefault());
            }
            catch(Exception e)
            {
                LogError(op.Name, e);
            }
        }

        void Emit(FastGenericOp op, CilMetadataIndex metadata, AsmArchive archive)
        {
            try
            {
                foreach(var r in op.Reifications)
                {
                    var arg = r.PrimalKind.ToPrimalType();
                    var method = op.Method.MakeGenericMethod(arg);
                    archive.Save(method.Descriptor(), metadata.FindCil(method).ValueOrDefault());
                }
            }
            catch(Exception e)
            {
                LogError(op.Name, e);
            }
        }

        void Emit(IEnumerable<FastGenericOp> ops, CilMetadataIndex metadata, AsmArchive archive)
        {
            foreach(var op in ops)
                Emit(op,metadata,archive);
        }

        void Emit(IEnumerable<FastDirectOp> ops, CilMetadataIndex metadata, AsmArchive archive)
        {
            foreach(var op in ops)
                Emit(op,metadata,archive);
        }

        void Emit(IOperationCatalog c)
        {
            var metadata = CilMetadataIndex.Create(c.DeclaringAssembly);                
            var archive = AsmArchive.Define(c.CatalogName);
            archive.Clear();
            Emit(c.GenericOps, metadata, archive);
            Emit(c.DirectOps, metadata, archive);

        }

        void Emit(IEnumerable<IOperationCatalog> catalogs)
        {
            iter(catalogs,Emit);
        }

        void EmitImmediates()
        {
            ResolveDynamic(n128,z32);
            ResolveDynamic(n256,z32);

        }
        
        void EmitUnaryImmResolutions(MethodInfo method, Moniker id,  AsmArchive archive)
        {
            var immediates = new byte[]{5,9,13};                        
            var parameters = method.GetParameters().ToArray();            
            var optype = parameters[0].ParameterType;
            var width = optype.SegmentedWidth();
            var celltype = optype.GetGenericArguments()[0];
            var factory = VectorImm.unaryfactory(width, method, celltype); 
            var buffer = new byte[1024];
            try
            {
                foreach(var imm in immediates)            
                {    
                    buffer.Clear();
                    var @delegate = factory(imm);                    
                    archive.Save(@delegate.ExtractCode(id.WithImm(imm), buffer));
                }
                    
            }
            catch(Exception e)
            {
                error(method.Signature());
                error(e);
            }
        }   

        void EmitUnaryImmResolutions(FastDirectOp op, AsmArchive archive)
        {
            EmitUnaryImmResolutions(op.Method, op.Id,archive);
        }   

        void EmitUnaryImmResolutions(FastGenericOp op, AsmArchive archive)
        {
            foreach(var (moniker, method) in op.Closures())
                EmitUnaryImmResolutions(method,moniker,archive);
        }

        void Emit(FastGenericOp op, AsmArchive archive)
        {
            foreach(var (moniker, method) in op.Closures())
            {
                var data = NativeReader.read(method);
                archive.Save(data.Code.WithId(moniker));             
            }
        }

        void Emit(FastDirectOp op, AsmArchive archive)
        {
            var data = NativeReader.read(op.Method);
            archive.Save(data.Code);             

        }

        public void EmitGeneric(Type host)
        {
            EmittingHostOps(host);

            var archive = AsmArchive.Define(host.Name);
            archive.Clear();

            var immArchive = AsmArchive.Define(ImmSubject);

            var fastops = host.FastOpGenerics();
            foreach(var op in fastops)
            {
                if(op.RequiresImmediate)
                {
                    // if(op.Method.IsUnaryImmVectorOp())
                    //     EmitUnaryImmResolutions(op,immArchive);
                }
                else
                    Emit(op,archive);
            }
        }

        public void EmitDirect(Type host)
        {
            EmittingHostOps(host);

            var archive = AsmArchive.Define(host.Name);
            archive.Clear();

            var immArchive = AsmArchive.Define(ImmSubject);


            var fastops = host.FastOpDirect();            
            foreach(var op in fastops)
            {
                if(op.RequiresImmediate)
                {
                    if(op.Method.IsUnaryImmVectorOp())
                        EmitUnaryImmResolutions(op,immArchive);
                }
                else
                    Emit(op, archive);
            }
        }

        public void EmitDirect(IOperationCatalog catalog)
            => iter(catalog.DirectApiHosts,EmitDirect);

        public void EmitGeneric(IOperationCatalog catalog)
            => iter(catalog.GenericApiHosts,EmitGeneric);

        public override void Execute()
        {
            //EmitImmediates();
            
            var immArchive = AsmArchive.Define(ImmSubject);
            immArchive.Clear();

            EmitDirect(IntrinsicsCatalog);
            EmitGeneric(IntrinsicsCatalog);


            //iter(IntrinsicsCatalog.Services, s => print(s.Name + s.Host.Name));
            

        }

    }
}