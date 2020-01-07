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
        
        public void Save(InstructionBlock block)
        {
            Paths.AsmDetailPath(Subject, block.Identity).WriteText(block.Format());
            Save(AsmCode.Load(block.Encoded, block.Identity));
        }

        public AsmCode ReadCode(Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(Subject, m).ReadText(),m);

        public InstructionBlock ReadDetail(Moniker m)
            => ReadCode(m).Decode();                    
    }

    class ArchiveControl : Controller<ArchiveControl>
    {        
        static IEnumerable<OpDescriptor> GenericOperators(int w, Type arg)
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
                        archive.Save(method.Descriptor(arg).NativeData.Instructions());
                }
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
                    archive.Save(method.Descriptor(arg).NativeData.Instructions());
            }
        }

        void Emit(Type host)
        {
            var archive = AsmArchive.Define(FolderName.Define(host.Name));
            foreach(var m in host.StaticMethods())   
                archive.Save(m.Descriptor().NativeData.Instructions());
        }

        void ReifyIntrinsics()
        {
            var host = typeof(ginx);
            var opnames = new string[]{
                nameof(ginx.vadd), nameof(ginx.vsub),
                nameof(ginx.vand), nameof(ginx.vor), nameof(ginx.vxor),
                nameof(ginx.vnand), nameof(ginx.vnor), nameof(ginx.vxnor)
                };
            var widths = items(128,256);

            ReifyIntrinsics(host, opnames, widths, Primitive.Integral);            
        }

        void ReifyPrimal()
        {
            var host = typeof(gmath);
            var opnames = new string[]{
                nameof(gmath.add), nameof(gmath.sub), nameof(gmath.odd), nameof(gmath.even),
                nameof(gmath.and), nameof(gmath.or), nameof(gmath.xor),
                nameof(gmath.nand), nameof(gmath.nor), nameof(gmath.xnor),
                nameof(gmath.select),nameof(gmath.blend),
                };
            ReifyPrimal(host, opnames, Primitive.Integral);

        }

        void ReifyPrimalBits()
        {
            var host = typeof(gbits);
            var opnames = new string[]{
                nameof(gbits.ntz),nameof(gbits.nlz),
                };
            ReifyPrimal(host, opnames, Primitive.UnsignedIntegral);

        }


        public override void Execute()
        {
            Emit(typeof(math));
            

        }

    }
}