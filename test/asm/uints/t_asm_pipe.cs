//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class t_asm_pipe : t_asm<t_asm_pipe>
    {
        static int activations;
        
        static void OnMnemonic(Instruction i)
        {            
            activations++;
        }

        static int listcount = 0;
        
        static AsmInstructionList Pipe(AsmInstructionList src)
        {        
            listcount++;
            return src;
        }

        public void check_archive()
        {            
            var paths = Paths.ForApp(PartId.Control);
            trace("Capture Path", $"{paths.AppCapturePath}");
        }

        void check_asm_pipe()
        {
            var archive =  Context.HostBits(PartId.GVec);
            var source = archive.ToInstructionSource(Context);
            var trigger = AsmMnemonicTrigger.Define(Mnemonic.Vinserti128, OnMnemonic);
            var triggers = AsmTriggerSet.Define(trigger);
            var flow =  Context.InstructionFlow(source, triggers);
            var pipe = AsmInstructionPipe.From(Pipe); 
            var results = flow.Flow(pipe).Force();

            var count = 0;
            foreach(var result in results)
            {
                foreach(var i in result)
                {
                    if(trigger.CanFire(i))
                        count++;
                }
            }    

            trace($"Trigger fired {count} times");        
        }
    }
}