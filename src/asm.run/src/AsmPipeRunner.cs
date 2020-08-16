//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static Konst;
    using static z;

    public readonly struct AsmPipeRunner
    {        
        public FilePath LogPath {get;}

        public IAppPaths AppPaths 
            => Z0.AppPaths.Default;        

        readonly AsmFxHandlers Handlers;
        
        readonly MemoryAddress BaseAddress;

        readonly int[] ListCount;

        ref int ListCounter
            => ref ListCount[0];

        [MethodImpl(Inline)]
        internal AsmPipeRunner(FilePath logpath)
        {
            LogPath = logpath;
            Handlers = AsmFxHandlers.Default;
            BaseAddress = Pow2.T08;
            ListCount = new int[]{0};
        }

        [MethodImpl(Inline)]
        public bool Include(AsmFxSink sink)
            => Handlers.Include(sink);

        public void Flow(params AsmRoutine[] src)
        {
            var count = src.Length;
            ref readonly var f = ref first(span(src));
            for(var i=0; i<count; i++)
                Flow(skip(f,i));
        }
        
        public void Flow(in AsmRoutine src)
        {
            var count = src.InstructionCount;
            ref readonly var inxs = ref src.Instructions[0];
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
        
        AsmFxList Pipe(AsmFxList src)
        {        
            ListCounter++;
            return src;
        }

        [MethodImpl(Inline)]
        AsmFxList ToList(AsmInstructions src)
            => asm.list(src, new LocatedCode(BaseAddress, src.Encoded));

        void RunPipe(ReadOnlySpan<IdentifiedCode> src, StreamWriter log)
        {
            var t1 = asm.trigger(Mnemonic.Vinserti128, Handlers.OnVinserti128);
            var t2 = asm.trigger(Mnemonic.Vmovupd, Handlers.OnVmovupd);
            var t3 = asm.trigger(Mnemonic.Call, Handlers.OnCall);
            var triggers = asm.set(t1,t2,t3);
            var decoded = UriHexDecoder.decode(src).Map(ToList);
            var fxFlow = asm.flow(decoded, triggers);
            var fxPipe = asm.pipe(Pipe); 
            var results = fxFlow.Push(fxPipe);

            log.WriteLine($"Analyzed {ListCounter} instruction lists");
            
            for(var i =0; i<(int)Mnemonic.LAST; i++)
            {
                var count = Handlers.Activations[i];
                if(count != 0)
                    log.WriteLine($"Logged {count} {(Mnemonic)i} activations");        
            }
        }

        [MethodImpl(Inline)]
        IPartCaptureArchive CaptureArchive(PartId part)
            => Capture.Services.CaptureArchive();

        [MethodImpl(Inline)]
        IPartCaptureArchive CaptureArchive(FolderPath root)
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