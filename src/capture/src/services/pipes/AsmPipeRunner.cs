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
    using System.IO;

    using static Konst;
    using static z;

    public readonly struct AsmPipeRunner
    {
        [MethodImpl(Inline)]
        public static AsmPipeRunner Create(FilePath logpath)
            => new AsmPipeRunner(logpath);
        
        public FilePath LogPath {get;}

        public TAppPaths AppPaths 
            => Z0.AppPaths.Default;        

        readonly InstructionHandlers Handlers;
        
        readonly MemoryAddress BaseAddress;

        readonly int[] ListCount;

        ref int ListCounter
            => ref ListCount[0];

        [MethodImpl(Inline)]
        internal AsmPipeRunner(FilePath logpath)
        {
            LogPath = logpath;
            Handlers = InstructionHandlers.Default;
            BaseAddress = Pow2.T08;
            ListCount = new int[]{0};
        }

        [MethodImpl(Inline)]
        public bool Include(InstructionSink sink)
            => Handlers.Include(sink);

        public void Flow(params AsmFunction[] src)
        {
            var count = src.Length;
            ref readonly var f = ref first(span(src));
            for(var i=0; i<count; i++)
                Flow(skip(f,i));
        }
        
        public void Flow(in AsmFunction src)
        {
            var count = src.InstructionCount;
            ref readonly var inxs = ref src.Inxs[0];
            for(var i=0; i<count; i++)
                Flow(skip(inxs,i));

        }
        
        public void Flow(in Instruction src)
        {

        }
        
        public Dictionary<Mnemonic,Instruction[]> RunPipe(params PartId[] parts)
        {            
            using var log = LogPath.Writer();
            var paths = AppPaths.ForApp(PartId.Control);
            var capture = CaptureArchive(paths.AppCaptureRoot);
            var archive = UriBitsArchive(capture.CodeDir);

            for(var i=0; i<parts.Length; i++)
            {
                var part = parts[i];
                var data = archive.Read(part).Array();
                log.WriteLine($"Running {part} instruction lists through the pipe");
                RunPipe(data,log);
            }

            return Handlers.Handled;       
        }
        
        AsmInstructionList Pipe(AsmInstructionList src)
        {        
            ListCounter++;
            return src;
        }

        [MethodImpl(Inline)]
        AsmInstructionList ToList(AsmInstructions src)
            => AsmInstructionList.Create(src, new LocatedCode(BaseAddress, src.Encoded));

        void RunPipe(ReadOnlySpan<IdentifiedCode> src, StreamWriter log)
        {
            var decoder = UriHexDecoder.Service;
            var t1 = AsmMnemonicTrigger.Define(Mnemonic.Vinserti128, Handlers.OnVinserti128);
            var t2 = AsmMnemonicTrigger.Define(Mnemonic.Vmovupd, Handlers.OnVmovupd);
            var t3 = AsmMnemonicTrigger.Define(Mnemonic.Call, Handlers.OnCall);
            var triggers = AsmTriggerSet.Define(t1,t2,t3);
            var decoded = decoder.Decode(src).Map(ToList);
            var flow = AsmInstructionFlow.Create(decoded, triggers);
            var pipe = AsmInstructionPipe.From(Pipe); 
            var results = flow.Push(pipe);

            log.WriteLine($"Analyzed {ListCounter} instruction lists");
            
            for(var i =0; i<(int)Mnemonic.LAST; i++)
            {
                var count = Handlers.Activations[i];
                if(count != 0)
                    log.WriteLine($"Logged {count} {(Mnemonic)i} activations");        
            }
        }

        [MethodImpl(Inline)]
        TPartCaptureArchive CaptureArchive(PartId part)
            => Capture.Services.CaptureArchive();

        [MethodImpl(Inline)]
        TPartCaptureArchive CaptureArchive(FolderPath root)
            => Capture.Services.CaptureArchive(root, null, null);

        [MethodImpl(Inline)]
        FilePath AsmFilePath<T>(PartId part) 
            => CaptureArchive(part).AsmPath<T>();

        [MethodImpl(Inline)]
        FilePath HexFilePath<T>(PartId part) 
            => CaptureArchive(part).HexPath<T>();

        [MethodImpl(Inline)]
        IEncodedHexArchive UriBitsArchive(FolderPath root)
            =>  Archives.Services.EncodedHexArchive(root);
    }
}