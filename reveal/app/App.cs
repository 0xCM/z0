//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Linq;

    using OC = Z0.OpCodes;

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
                    emitter.EmitAsm(t.DistillAsmFunctions(),false);                    
                }

                if(cil)
                    Deconstructor.Deconstruct(t).EmitCil(t.DisplayName());
            }
        }


        static void EmitAsm(Type[] types, FilePath dst)
        {
            var emitter = AsmCodeEmitter.Create(dst);
            emitter.EmitAsm(types,dst);
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
            
            //Deconstructor.Shred(typeof(math), typeof(fmath), typeof(Bits),typeof(dinx));
            
            Disassemble(new ExperimentalScenarios());
            Disassemble(typeof(OC.msops));    
            Disassemble(typeof(OC.butterfly));    
            Disassemble(typeof(OC.bitmask));
            Disassemble(typeof(OC.bitmatrix));    
            Disassemble(typeof(OC.bitstore));
            Disassemble(typeof(OC.bitpack));    
            Disassemble(typeof(OC.bitspan));    
            Disassemble(typeof(OC.bitconvert));    
            Disassemble(typeof(OC.stacked));    
            Disassemble(typeof(OC.loops));    

            Disassemble(typeof(OC.nats));    

            Disassemble(typeof(OC.memory));    
            Disassemble(typeof(OC.sconvert));   
            Disassemble(typeof(OC.sbits));    
            Disassemble(typeof(OC.pop));   
            Disassemble(typeof(OC.logix));
            Disassemble(typeof(OC.logixmat));
            Disassemble(typeof(OC.rowbits));
            Disassemble(typeof(OC.bitcore));    


            Disassemble(typeof(inxoc));    
            Disassemble(typeof(vxops));    
            Disassemble(typeof(OC.v512));    
            Disassemble(typeof(OC.vblend));
            Disassemble(typeof(OC.vblockops));    
            Disassemble(typeof(OC.vconvert));    
            Disassemble(typeof(OC.vcompare));    
            Disassemble(typeof(OC.vload));    
            Disassemble(typeof(OC.vmov));    
            Disassemble(typeof(OC.vpattern));    
            Disassemble(typeof(OC.vpermoc));    
            Disassemble(typeof(OC.vshift));  

            Disassemble(typeof(gmathops));    
            Disassemble(typeof(OC.gxops));    

            Disassemble(typeof(zfoc));    
            Disassemble(typeof(bitvectors));    
            Disassemble(typeof(bitgrid));   

        }

        public unsafe void ListMethods(Type t)
        {
            var methods = (from m in t.DeclaredMethods()
                          let loc = (long)m.Jit()
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

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class OpCodeProvider : Attribute
    {


    }

 
}