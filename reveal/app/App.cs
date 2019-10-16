//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;


    class App
    {                
        static readonly FolderPath DumpFolder
            = FolderPath.Define(Settings.ProjectDir("reveal")) +  FolderName.Define(".dumps");
        
        static FilePath DefineAsmOutPath(string label)
            => DumpFolder + (FileName.Define(label) + FileExtension.Define("asm"));

        static void Disassemble(bool asm, bool cil, params Type[] types)
        {
            foreach(var t in types)
            {
                var name = $"{t.DisplayName()}";
                if(asm)
                {
                    var dstPath = AsmCodeEmitter.OutPath(DumpFolder, t.DisplayName());
                    var emitter = AsmCodeEmitter.Create(dstPath);
                    emitter.EmitAsm(t.DistillAsm());                    
                }

                if(cil)
                    Deconstructor.Deconstruct(t).EmitCil(t.DisplayName());
            }

        }

        public static Option<MethodDisassembly> DeconstructGeneric<T>(Type host, string opname)
        {
            var method = 
                (from m in host.Methods().Public().OpenGeneric()
                    where opname == m.Name
                let parms = m.GetParameters()
                where ! parms.Any(p => p.IsRetval || p.IsIn || p.IsOut)
                select m).FirstOrDefault();
            return method == null ? default : Deconstructor.DeconstructGeneric<T>(method);            
        }
        public static MethodDisassembly[] DeconstructGeneric(Type host, string[] opnames, Type[] typeargs, string name)
        {
            var open = from m in host.Methods().Public().OpenGeneric()
                where opnames.Contains(m.Name)
                let parms = m.GetParameters()
                where ! parms.Any(p => p.IsRetval || p.IsIn || p.IsOut)
                select m;

            var closed = (from om in open
                         from t in typeargs
                         let def = om.GetGenericMethodDefinition()
                         let gm = def.MakeGenericMethod(t)
                         select gm).ToArray();
            var deconstructed = Deconstructor.Deconstruct(closed);
            if(deconstructed.Length != 0)
                deconstructed.Emit(name);
            return deconstructed;
        }

        static void Disassemble<T>(IDeconstructable<T> src)
        {
            var deconstructed = Deconstructor.Deconstruct(typeof(T));
            deconstructed.EmitAsm(src.AsmTargetPath);
            deconstructed.EmitCil(src.CilTargetPath);            
        }

        void Disassemble(Type t)
            => Disassemble(true, true, t);
        void Disassemble(bool asm, bool cil)
        {
            Disassemble(new ExperimentalScenarios());
            Disassemble(typeof(math));
            Disassemble(typeof(dinx));    
            Disassemble(typeof(bitvector));    
            Disassemble(typeof(pmoc));    
            Disassemble(typeof(loc));    
            Disassemble(typeof(bvoc));    
            Disassemble(typeof(bmoc));    
            Disassemble(typeof(inxsoc));    
            Disassemble(typeof(inxvoc));    
            Disassemble(typeof(zfoc));    
            Disassemble(typeof(fpoc));    
            Disassemble(typeof(circop));    
            Disassemble(typeof(BitParts));                
            Disassemble(typeof(BooleanLogic));                
        }

        public unsafe void ListMethods(Type t)
        {
            var methods = (from m in t.DeclaredMethods()
                          let loc = (long)m.JitMethod()
                          select (m, loc)).OrderBy(x => x.loc).ToArray();
            if(methods.Length == 0)
                return;

            var first = methods[0].loc;
            var last = 0L;
            foreach(var m in methods)
            {                
                var length = last != 0 ? m.loc - last : 0;
                last = m.loc;
                print($"{m.loc.FormatHex(false)} {m.m.Name.PadRight(15)} {length}");
            }


        }

        void Run()
        {

            try
            {
                //ListMethods(typeof(PrimalScenarios));
                Disassemble(true,true);
            }
            catch(Exception e)
            {
                print(errorMsg(e));
            }
        }

        public static void Main(params string[] args)
            => new App().Run();

    }

}