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

    using static zfunc;

    class ArchiveControl : Controller<ArchiveControl>
    {        
        byte[] AsmBuffer = new byte[500];

        AsmCodeSet Resolve<T>(IVUnaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            AsmBuffer.Fill(byte.MinValue);
            return NativeReader.read(f, AsmBuffer).CodeSet(moniker.WithImm(imm8), f.CilFunc());
        }

        AsmCodeSet Resolve<T>(IVBinaryImm8Resolver128<T> svc, byte imm8)
            where T : unmanaged
        {
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);            
            AsmBuffer.Fill(byte.MinValue);
            return NativeReader.read(f, AsmBuffer).CodeSet(moniker.WithImm(imm8), f.CilFunc());
        }

        void Clear(string subject)
            => AsmArchive.Define(subject).Clear();

        void Append(string subject, params AsmCodeSet[] ops)
        {
            var archive = AsmArchive.Define(subject);
            for(var i=0; i<ops.Length; i++)
                archive.Save(ops[i]);
        }

        void Reify(IAssemblyDesignator designator)
        {
            var metadata = CilMetadataIndex.Create(designator.DeclaringAssembly);
            foreach(var api in designator.ApiProviders)
            {
                var archive = AsmArchive.Define(api.Name);
                archive.Clear();
                foreach(var opname in designator.OpNames)
                {
                    var methods = api.StaticMethods().Public().WithName(opname).ToArray();
                    foreach(var method in methods)
                    {
                        if(method.RequiresImmediate())
                        {

                        }
                        else if(method.IsOpenGeneric())
                        {
                            var args = method.SupportedPrimals().Select(x => x.ToPrimalType()).ToArray();
                            if(args.Length == 0)
                                args = Classified.IntegralKinds.Select(k => k.ToPrimalType()).ToArray();
                            
                            foreach(var arg in args)
                            {
                                var d = method.Descriptor(arg);
                                archive.Save(d, metadata.FindCil(d.Method).ValueOrDefault());
                            }
                        }
                        else
                        {
                            var d = method.Descriptor();
                            archive.Save(d,metadata.FindCil(d.Method).ValueOrDefault());
                        }
                    }
                }
            }
        }
        
        public IEnumerable<AsmCodeSet> Resolve<T>(IVUnaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select Resolve(svc,imm);

        public IEnumerable<AsmCodeSet> Resolve<T>(IVBinaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select Resolve(svc,imm);

        public IEnumerable<AsmCodeSet> Resolve<T>(IEnumerable<IVUnaryImm8Resolver128<T>> services, params byte[] immediates)
            where T : unmanaged
                =>  from svc in services
                    from imm in immediates 
                    select Resolve(svc,imm);

        string DynamicSubject
            => nameof(ginx) + "_dynamic";

        void ResolveDynamic<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var imm = new byte[]{3, 13, 25, 28, 30};
            var r1 = Resolve(VX.vbsll(w,t),imm);
            var r2 = Resolve(VX.vsrl(w,t),imm);
            var r3 = Resolve(VX.vblend8x16(w,t),imm);
            var resolutions = r1.Union(r2).Union(r3).ToArray();
            Append(DynamicSubject, resolutions);

        }

        public override void Execute()
        {
            Clear(DynamicSubject);
            ResolveDynamic(n128,z32);

            var archive = AsmArchive.Define(nameof(dinx));
            var f = archive.ReadFunction(Moniker.define("vadd", PrimalKind.U8, n128));
            print(f.Format());

        }

    }
}