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
    using System.Runtime.Intrinsics;
    using System.Reflection.Emit;

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

        public void SaveAsm(AsmCode asm)
            => Paths.AsmHexPath(Subject, asm.Name).WriteText(asm.Format());
        
        public void SaveAsm(InstructionBlock block, Moniker m)
        {
            Paths.AsmDetailPath(Subject, m).WriteText(block.Format());
            SaveAsm(AsmCode.Load(block.Encoded, m));
        }

        public void Save(OpData src)
        {
            Paths.AsmDetailPath(Subject, src.Moniker).WriteText(src.Asm.Format());
            SaveAsm(AsmCode.Load(src.Asm.Encoded, src.Moniker));
        }

        void SaveCil(CilFuncSpec cil, Moniker m)
        {
            Paths.CilPath(Subject,m).WriteText(cil.Format());
        }

        public void Save(Operation op, CilFuncSpec cil = null)
        {
            SaveAsm(op.NativeData.Instructions(), op.Moniker);
            if(cil != null)
                SaveCil(cil, op.Moniker);            
        }

        public void Clear()
        {
            Location.DeleteFiles();
        }

        public AsmCode ReadCode(Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(Subject, m).ReadText(),m);

        public InstructionBlock ReadDetail(Moniker m)
            => ReadCode(m).Decode();                    
    }

    public class OpData
    {
        public static OpData Define(Moniker moniker, InstructionBlock asm, CilFunction cil)
            => new OpData(moniker, asm,cil);

        public OpData(Moniker moniker, InstructionBlock asm, CilFunction cil)
        {
            this.Moniker = moniker;
            this.Asm = asm;
            this.Cil = cil;
        }

        public Moniker Moniker {get;}        

        public InstructionBlock Asm {get;}

        public CilFunction Cil {get;}

        public string Format()
            => Asm.Format();
    }

    class ArchiveControl : Controller<ArchiveControl>
    {        
        byte[] AsmBuffer = new byte[500];

        OpData vbsll_dynamic<T>(byte imm8)
            where T : unmanaged
        {
            var svc = VX.vbsll<T>(n128);
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            
            AsmBuffer.Fill(byte.MinValue);
            var x86 = NativeReader.read(f,AsmBuffer).Instructions();
            return OpData.Define(moniker, x86, f.CilFunc());
        }


        OpData vsrl_dynamic<T>(byte imm8)
            where T : unmanaged
        {
            var svc = VX.vsrl<T>(n128);
            var moniker = svc.Moniker;
            var f = svc.@delegate(imm8);
            
            AsmBuffer.Fill(byte.MinValue);
            var x86 = NativeReader.read(f, AsmBuffer).Instructions();
            return OpData.Define(moniker, x86, f.CilFunc());
            
        }

        void Save(string subject, params OpData[] ops)
        {
            var archive = AsmArchive.Define(FolderName.Define(subject));
            for(var i=0; i<ops.Length; i++)
                archive.Save(ops[i]);
        }

        void Reify(IAssemblyDesignator designator)
        {
            var metadata = CilMetadataIndex.Create(designator.DeclaringAssembly);
            foreach(var api in designator.ApiProviders)
            {
                var archive = AsmArchive.Define(FolderName.Define(api.Name));
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

        public override void Execute()
        {

            Save(nameof(ginx) + "_dynamic", vbsll_dynamic<ulong>(14), vsrl_dynamic<ulong>(18));

            // print(vbsll_dynamic().Format());
            // print(vsrl_dynamic().Format());

            // Reify(Designate("z0.intrinsics").Require());
            // Reify(Designate("z0.gmath").Require());
            

        }

    }
}