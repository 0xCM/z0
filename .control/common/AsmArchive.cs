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

    public class AsmArchive
    {
        public static AsmArchive Define(string subject)
            => new AsmArchive(subject);

        AsmArchive(string subject)
        {
            this.Subject = FolderName.Define(subject);
            this.Location = LogPaths.The.AsmDataDir(this.Subject);
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

        public void Save(AsmCodeSet src)
        {
            Paths.AsmDetailPath(Subject, src.Moniker).WriteText(src.Decoded.Format());
            SaveAsm(AsmCode.Load(src.Decoded.Encoded, src.Moniker));
        }

        public void Save(Operation op, CilFuncSpec cil = null)
        {
            SaveAsm(op.NativeData.Instructions(), op.Moniker);
            if(cil != null)
                Paths.CilPath(Subject,op.Moniker).WriteText(cil.Format());                
        }

        public void Clear()
        {
            Location.DeleteFiles();
        }

        public AsmCode ReadCode(Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(Subject, m).ReadText(),m);

        public InstructionBlock ReadInstructions(Moniker m)
            => ReadCode(m).DistillInstructions();          

        public AsmFuncInfo ReadFunction(Moniker m)          
            => ReadCode(m).DistillAsmFunction();
    }
}