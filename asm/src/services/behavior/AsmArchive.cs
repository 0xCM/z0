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
            TargetFolder = LogPaths.The.AsmDataDir(FolderName.Define(subject));
        }
    
        FolderPath TargetFolder {get;}
        
        public void Save(FastDirectInfo op)
            => Save(op.Method.FastOp().NativeData);                

        public void Save(FastGenericInfo op)
        {
            foreach(var k in op.Kinds)
            {
                var method = op.Method.MakeGenericMethod(k.ToPrimalType());
                Save(method.FastOp().NativeData);
            }
        }

        public void Save(MethodDisassembly src)
        {
            Paths.AsmHexPath(TargetFolder, src.Id).WriteText(src.AsmCode.Format());
            Paths.AsmDetailPath(TargetFolder, src.Id).WriteText(AsmFunction.from(src).FormatDetail());
            src.CilFunction.OnSome(cil => Paths.CilPath(TargetFolder, src.Id).WriteText(cil.Format()));
        }

        public void Save(AsmCodeSet src)
        {
            Paths.AsmHexPath(TargetFolder, src.Id).WriteText(src.Encoded.Format());
            Paths.AsmDetailPath(TargetFolder, src.Id).WriteText(AsmFunction.from(src).FormatDetail());
        }

        public void Save(INativeMemberData src)
        {
            Paths.AsmHexPath(TargetFolder, src.Id).WriteText(src.Code.Format());
            Paths.AsmDetailPath(TargetFolder, src.Id).WriteText(AsmFunction.decode(src).FormatDetail());
        }

        public void Save(IEnumerable<AsmCodeSet> codesets)
        {
            foreach(var cs in codesets)
                Save(cs);
        }

            
        public void Clear()
        {
            TargetFolder.DeleteFiles();
        }

        public Option<AsmCode> ReadCode(Moniker m)
            =>  from text in Paths.AsmHexPath(TargetFolder, m).TryReadText()
                let code = AsmCode.Parse(text,m)
                select code;
    }
}