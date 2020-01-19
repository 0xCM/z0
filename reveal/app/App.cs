//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Linq;
    using Z0.Designators;

    using OC = Z0.OpCodes;

    using static zfunc;

    class App
    {                
        static readonly FolderPath DumpFolder
            = FolderPath.Define(Settings.ProjectDir("reveal")) +  FolderName.Define(".dumps");
        
        static FilePath AsmOutPath(string label)
            => DumpFolder + (FileName.Define(label) + FileExtension.Define("asm"));


        static void Deconstruct(bool asm, bool cil, params Type[] types)
        {
            foreach(var t in types)
            {
                var deconstructed = Deconstructor.Deconstruct(t);

                if(asm)
                {
                    var dstPath = AsmCodeEmitter.OutPath(DumpFolder, t.DisplayName());
                    var emitter = AsmCodeEmitter.Create(dstPath);
                    emitter.EmitAsm(AsmFunction.from(deconstructed),false);
                    // var functions = AsmFunction.from(Deconstructor.Deconstruct(t));
                    // emitter.EmitAsm(functions,false);                    
                }

                if(cil)
                    Deconstructor.Deconstruct(t).EmitCil(t.DisplayName());
            }
        }


        static void Deconstruct<T>(IDeconstructable<T> src)
        {
            var deconstructed = Deconstructor.Deconstruct(typeof(T));
            deconstructed.EmitAsm(src.AsmTargetPath);
            deconstructed.EmitCil(src.CilTargetPath);            
        }

        void Disassemble(Type t)
            => Deconstruct(true, true, t);


        void Disassemble(bool asm, bool cil)
        {
            
            //Deconstructor.Shred(typeof(math), typeof(fmath), typeof(Bits),typeof(dinx));
            
            Deconstruct(new ExperimentalScenarios());
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