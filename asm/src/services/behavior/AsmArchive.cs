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

    public class AsmArchive
    {
        public static AsmArchive Define(string subject)
            => new AsmArchive(subject);

        AsmArchive(string subject)
        {
            Location = LogPaths.The.AsmDataDir(FolderName.Define(subject));
        }
    
        FolderPath Location {get;}
        
        public void Save(AsmCode code, CilFunction cil = null)
        {
            Paths.AsmHexPath(Location, code.Id).WriteText(code.Format());
            Paths.AsmDetailPath(Location, code.Id).WriteText(AsmFunction.decode(code).FormatDetail());
            if(cil != null)
                Paths.CilPath(Location, code.Id).WriteText(cil.Format());
        }

        public void Save(IEnumerable<AsmCode> code, CilFunction cil = null)
        {
            foreach(var c in code)
                Save(c,cil);
        }
            
        public void Clear()
        {
            Location.DeleteFiles();
        }


        public Option<AsmCode> ReadCode(Moniker m)
            =>  from text in Paths.AsmHexPath(Location, m).TryReadText()
                let code = AsmCode.Parse(text,m)
                select code;

        // public InstructionBlock ReadInstructions(Moniker m)
        //     => AsmDecoder.decode(ReadCode(m));

        // public AsmFuncInfo ReadFunction(Moniker m)          
        //     => AsmFunction.decode(ReadCode(m));

    }
}