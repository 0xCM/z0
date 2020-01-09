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
    using System.Threading;
    using System.Reflection;

    using static ControlMessages;
    using static zfunc;

    public class AsmArchive
    {
        public static AsmArchive Define(FolderName subject)
            => new AsmArchive(subject);

        public AsmArchive(FolderName subject)
        {
            this.Subject = subject;
            this.Location = LogPaths.The.AsmDataDir(subject);
        }

        FolderName Subject {get;}

        FolderPath Location {get;}

        public void Save(AsmCode asm)
            => Paths.AsmHexPath(Subject, asm.Name).WriteText(asm.Format());
        
        public void Save(InstructionBlock block, Moniker m)
        {
            Paths.AsmDetailPath(Subject, m).WriteText(block.Format());
            Save(AsmCode.Load(block.Encoded, m));
        }

        public AsmCode ReadCode(Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(Subject, m).ReadText(),m);

        public InstructionBlock ReadDetail(Moniker m)
            => ReadCode(m).Decode();                    
    }

    class ArchiveControl : Controller<ArchiveControl>
    {        
        static IEnumerable<Operation> GenericOperators(int w, Type arg)
            => typeof(ginx).StaticMethods().OpenGeneric().Operators().Vectorized(w).Select(m => m.Descriptor(arg));

        void DisplayIntrinsics(int w, Type arg)        
        {
            foreach(var opsig in GenericOperators(w,arg))
                print(appMsg($"{opsig.FormatMapping()} (moniker: {opsig.Moniker})"));
        }

        void ReifyIntrinsics(Type host, IEnumerable<string> opnames, IEnumerable<int> widths, IEnumerable<Type> args)
        {            
            var archive = AsmArchive.Define(FolderName.Define(host.Name));
            foreach(var opname in opnames)
            {
                foreach(var w in widths)
                {
                    var methods = host.StaticMethods().WithName(opname).OpenGeneric().Vectorized(w,true).ToArray();
                    foreach(var method in methods)
                    foreach(var arg in args)
                    {
                        var descriptor = method.Descriptor(arg);
                        archive.Save(descriptor.NativeData.Instructions(), descriptor.Moniker);
                    }
                }
            }
        }

        void ReifyIntrinsics()
        {            
            var gArchive = AsmArchive.Define(FolderName.Define(typeof(ginx).Name));
            var dArchive = AsmArchive.Define(FolderName.Define(typeof(dinx).Name));
            var opnames = Designate("z0.intrinsics").Require().OpNames.ToHashSet();
            var generics = typeof(ginx).StaticMethods().WithName(opnames).Operators().Unblocked().Public().OpenGeneric().ToArray();

            foreach(var g in generics)
            {
                var args = g.SupportedPrimals().ToArray();
                if(args.Length == 0)
                    args = Classified.IntegralKinds.ToArray();
                
                foreach(var arg in args)
                {
                    var descriptor = g.Descriptor(arg.PrimalType());
                    gArchive.Save(descriptor.NativeData.Instructions(), descriptor.Moniker);                                        
                }
            }

            foreach(var direct in typeof(dinx).StaticMethods().Public().WithName(opnames).ToArray())
            {
                var descriptor = direct.Descriptor();
                dArchive.Save(descriptor.NativeData.Instructions(), descriptor.Moniker);
            }
        }

        void ReifyPrimal(Type host, IEnumerable<string> opnames, IEnumerable<Type> args)
        {
            var archive = AsmArchive.Define(FolderName.Define(host.Name));
            foreach(var opname in opnames)
            {
                var methods = host.StaticMethods().WithName(opname).OpenGeneric().ToArray();
                foreach(var method in methods)
                foreach(var arg in args)
                {
                    var d = method.Descriptor(arg);
                    archive.Save(d.NativeData.Instructions(),d.Moniker);
                }
            }
        }

        void ReifyGeneric(FolderName subject, IEnumerable<MethodInfo> methods, IEnumerable<Type> args)
        {
            var archive = AsmArchive.Define(subject);
            foreach(var method in methods)
            {
                foreach(var arg in args)
                {
                    
                    var d = method.Descriptor(arg);
                    archive.Save(d.NativeData.Instructions(),d.Moniker);
                }
            }
        }

        void Emit(Type host)
        {
            var archive = AsmArchive.Define(FolderName.Define(host.Name));
            foreach(var m in host.StaticMethods())   
            {
                var d = m.Descriptor();
                archive.Save(d.NativeData.Instructions(),d.Moniker);
            }
        }

        void Emit(FolderName subject, IEnumerable<MethodInfo> methods)
        {
            var archive = AsmArchive.Define(subject);   
            foreach(var m in methods)   
            {
                var d = m.Descriptor();
                archive.Save(d.NativeData.Instructions(), d.Moniker);
            }
        }

        void EmitPrimal()
        {                    
            
            var opnames = Designate("z0.gmath").Require().OpNames.ToHashSet();
            ReifyGeneric(FolderName.Define(nameof(gmath)), typeof(gmath).StaticMethods().Public().WithName(opnames).OpenGeneric(), Classified.IntegralTypes);
            Emit(FolderName.Define(nameof(math)), typeof(math).StaticMethods().Public().Concrete().WithName(opnames));
                        

        }

        void ReifyPrimalBits()
        {
            var host = typeof(gbits);
            var opnames = new string[]{
                nameof(gbits.ntz),nameof(gbits.nlz),
                };
            ReifyPrimal(host, opnames, Classified.UnsignedTypes);

        }


        public override void Execute()
        {
            ReifyIntrinsics();
            //Emit(FolderName.Define(nameof(math)),typeof(math).StaticMethods().Concrete().Public().Operators());            

        }

    }
}