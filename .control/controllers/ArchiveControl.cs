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

        public void SaveAsm(AsmCode asm)
            => Paths.AsmHexPath(Subject, asm.Name).WriteText(asm.Format());
        
        public void SaveAsm(InstructionBlock block, Moniker m)
        {
            Paths.AsmDetailPath(Subject, m).WriteText(block.Format());
            SaveAsm(AsmCode.Load(block.Encoded, m));
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

    class ArchiveControl : Controller<ArchiveControl>
    {        
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
                        if(method.IsOpenGeneric())
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

            //Reify(Designate("z0.intrinsics").Require());
            Reify(Designate("z0.gmath").Require());
            

        }

    }
}