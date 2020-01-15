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
            Location = LogPaths.The.AsmDataDir(FolderName.Define(subject));
        }
    
        FolderPath Location {get;}

        public void SaveAsm(AsmCode asm)
            => Paths.AsmHexPath(Location, asm.Name).WriteText(asm.Format());
        
        public void SaveAsm(InstructionBlock block, Moniker m)
        {
            Paths.AsmDetailPath(Location, m).WriteText(block.Format());
            SaveAsm(AsmCode.Load(block.Encoded, m));
        }

        public void Save(AsmCodeSet src)
        {
            Paths.AsmDetailPath(Location, src.Moniker).WriteText(src.Decoded.Format());
            SaveAsm(AsmCode.Load(src.Decoded.Encoded, src.Moniker));
        }

        public void Save(Operation op, CilFuncSpec cil = null)
        {
            SaveAsm(op.NativeData.Instructions(), op.Moniker);
            if(cil != null)
                Paths.CilPath(Location,op.Moniker).WriteText(cil.Format());                
        }

        public void Clear()
        {
            Location.DeleteFiles();
        }

        public AsmCode ReadCode(Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(Location, m).ReadText(),m);

        public InstructionBlock ReadInstructions(Moniker m)
            => ReadCode(m).DistillInstructions();          

        public AsmFuncInfo ReadFunction(Moniker m)          
            => ReadCode(m).DistillAsmFunction();
    }
}