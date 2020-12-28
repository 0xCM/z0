//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    //public delegate void InstructionReceiver(in Instruction src);

    // public readonly struct AsmPipeRunner
    // {
    //     readonly IWfShell Wf;

    //     readonly IWfDb Db;

    //     readonly MemoryAddress BaseAddress;

    //     readonly int[] ListCount;

    //     readonly InstructionReceiver[] Receivers;

    //     readonly uint ReceiverCount;

    //     ref int ListCounter
    //         => ref ListCount[0];

    //     [MethodImpl(Inline)]
    //     internal AsmPipeRunner(IWfShell wf, params InstructionReceiver[] receivers)
    //     {
    //         Wf = wf;
    //         Db = Wf.Db();
    //         BaseAddress = Pow2.T08;
    //         ListCount = new int[]{0};
    //         Receivers = receivers;
    //         ReceiverCount = (uint)Receivers.Length;
    //     }

    //     public void Flow(params AsmRoutine[] src)
    //     {
    //         var count = src.Length;
    //         ref readonly var f = ref first(span(src));
    //         for(var i=0; i<count; i++)
    //             Flow(skip(f,i));
    //     }

    //     public void Flow(in AsmRoutine src)
    //     {
    //         var count = src.InstructionCount;
    //         ref readonly var fx = ref src.Instructions[0];
    //         for(var i=0; i<count; i++)
    //             Flow(skip(fx,i));
    //     }

    //     public void Flow(in Instruction src)
    //     {
    //         for(var i=0; i<ReceiverCount; i++)
    //             skip(Receivers,i)(src);
    //     }

    //     public void RunPipe(params PartId[] parts)
    //     {
    //         using var log = Db.TaskLogPath("AsmPipeRunner").Writer();

    //         var capture = CaptureArchive(Db.CaptureRoot());
    //         var archive = UriBitsArchive(capture.HexDir);
    //         for(var i=0; i<parts.Length; i++)
    //         {
    //             var part = parts[i];
    //             var data = archive.ApiCode(part).Array();
    //             log.WriteLine($"Running {part} instruction lists through the pipe");
    //             RunPipe(data,log);
    //         }
    //     }

    //     AsmFxList Pipe(AsmFxList src)
    //     {
    //         ListCounter++;
    //         return src;
    //     }

    //     [MethodImpl(Inline)]
    //     AsmFxList ToList(AsmInstructions src)
    //         => asm.list(src, new CodeBlock(BaseAddress, src.Data));

    //     void RunPipe(ReadOnlySpan<ApiCodeBlock> src, StreamWriter log)
    //     {
    //         var handlers = new AsmFxHandlers();
    //         var t1 = asm.trigger(Mnemonic.Vinserti128, handlers.OnVinserti128);
    //         var t2 = asm.trigger(Mnemonic.Vmovupd, handlers.OnVmovupd);
    //         var t3 = asm.trigger(Mnemonic.Call, handlers.OnCall);
    //         var triggers = asm.triggers(t1,t2,t3);
    //         var decoded = CodeBlockDecoder.decode(src).Map(ToList);
    //         var fxFlow = asm.flow(decoded, triggers);
    //         var fxPipe = asm.pipe(Pipe);
    //         var results = fxFlow.Push(fxPipe);

    //         log.WriteLine($"Analyzed {ListCounter} instruction lists");

    //         for(var i =0; i<(int)Mnemonic.LAST; i++)
    //         {
    //             var count = handlers.Activations[i];
    //             if(count != 0)
    //                 log.WriteLine($"Logged {count} {(Mnemonic)i} activations");
    //         }
    //     }

    //     [MethodImpl(Inline)]
    //     ICaptureArchive CaptureArchive(FS.FolderPath root)
    //         => WfArchives.capture(root);

    //     [MethodImpl(Inline)]
    //     ApiHexArchive UriBitsArchive(FS.FolderPath root)
    //         => WfArchives.hex(root);
    // }
}