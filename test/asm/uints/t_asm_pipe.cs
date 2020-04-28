//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;

    public class t_asm_pipe : t_asm<t_asm_pipe>
    {
        ulong[] Activations;

        public t_asm_pipe()
        {
            Activations = new ulong[(int)Mnemonic.LAST + 1];
        }
        
        void OnVinserti128(Instruction i)
        {            
            Activations[(int)i.Mnemonic]++;
        }

        void OnVmovupd(Instruction i)
        {
            Activations[(int)i.Mnemonic]++;
        }

        void OnCall(Instruction i)
        {
            Activations[(int)i.Mnemonic]++;
        }

        int listcount = 0;
        
        AsmInstructionList Pipe(AsmInstructionList src)
        {        
            listcount++;
            return src;
        }

        public void check_archive()
        {            
            var paths = Paths.ForApp(PartId.Control);
            var capture = Archives.Services.CaptureArchive(paths.AppCapturePath);
            var bits = HostBitsArchive.Create(PartId.Control, capture.HexDir);
            var data = bits.Read(PartId.GVec);
            check_asm_pipe(data);
        }

        void check_asm_pipe(IEnumerable<OperationBits> src)
        {
            var decoder = OperationBitDecoder.Service;
            var source = AsmInstructionSource.From(() => decoder.Decode(src));
            var t1 = AsmMnemonicTrigger.Define(Mnemonic.Vinserti128, OnVinserti128);
            var t2 = AsmMnemonicTrigger.Define(Mnemonic.Vmovupd, OnVmovupd);
            var t3 = AsmCallTrigger.Define(OnCall);
            var triggers = AsmTriggerSet.Define(t1,t2,t3);
            var flow = AsmInstructionFlow.Create(source, triggers);
            var pipe = AsmInstructionPipe.From(Pipe); 
            var results = flow.Flow(pipe).Force();


            for(var i =0; i<(int)Mnemonic.LAST; i++)
            {
                var count = Activations[i];
                if(count != 0)                
                    trace($"Logged {count} {(Mnemonic)i} activations");        
            }
        }
    }
}