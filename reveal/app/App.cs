//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Linq;
    using Z0.Logix;

    using static zfunc;


    class App
    {                
        static readonly FolderPath DumpFolder
            = FolderPath.Define(Settings.ProjectDir("reveal")) +  FolderName.Define(".dumps");
        
        static FilePath AsmOutPath(string label)
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

        static void EmitAsm(Type[] types, FilePath dst)
        {
            var emitter = AsmCodeEmitter.Create(dst);
            dst.DeleteIfExists();
            iter(types, t => emitter.EmitAsm(t.DistillAsm(),true));
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

        /// <summary>
        /// Emits assembly for an entire assembly. Heh.
        /// </summary>
        /// <param name="a">The source assembly from which the assembly will be distilled</param>
        void EmitAsm(Assembly a)
            => EmitAsm(a.GetTypes(), AsmOutPath(a.GetSimpleName()));

        void EmitAsm(IAssemblyDesignator a)
            => EmitAsm(a.DeclaringAssembly);

        void Disassemble(bool asm, bool cil)
        {
            Disassemble(new ExperimentalScenarios());
            Disassemble(typeof(inxsoc));    
            Disassemble(typeof(inxvoc));    
            Disassemble(typeof(inxcoc));   
            Disassemble(typeof(pmoc));    
            Disassemble(typeof(zfoc));    
            Disassemble(typeof(fpoc));    
            Disassemble(typeof(circop));    
            Disassemble(typeof(bvoc));    
            Disassemble(typeof(bmoc));    
            Disassemble(typeof(convoc));   
            Disassemble(typeof(math));
            Disassemble(typeof(dinx));    
            Disassemble(typeof(BitVector));    
            Disassemble(typeof(Bits));    
            Disassemble(typeof(BitParts));  
            EmitAsm(Designators.Logix.Designated);  
            // Disassemble(typeof(LogicOps));   
            // Disassemble(typeof(LogicExprEval));             
            // Disassemble(typeof(LogicDispatcher)); 
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