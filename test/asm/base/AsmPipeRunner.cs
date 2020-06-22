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

    public readonly struct AsmPipeRunner
    {
        [MethodImpl(Inline)]
        public static AsmPipeRunner Create(TAppPaths paths, IArchives src, FilePath logpath)
            => new AsmPipeRunner(paths,src,logpath);
        
        public FilePath LogPath {get;}

        public TAppPaths AppPaths {get;}
        
        public IArchives DataSource {get;}

        readonly InstructionHandlers Handlers;
        
        readonly MemoryAddress BaseAddress;

        readonly int[] ListCount;

        ref int ListCounter
            => ref ListCount[0];

        [MethodImpl(Inline)]
        internal AsmPipeRunner(TAppPaths paths, IArchives src, FilePath logpath)
        {
            AppPaths = paths;
            DataSource = src;
            LogPath = logpath;
            Handlers = InstructionHandlers.Default;
            BaseAddress = Pow2.T08;
            ListCount = new int[]{0};
        }

        public Dictionary<Mnemonic,Instruction[]> RunPipe(params PartId[] parts)
        {            
            using var log = LogPath.Writer();
            var paths = AppPaths.ForApp(PartId.Control);
            var capture = CaptureArchive(paths.AppCapturePath);
            var archive = UriBitsArchive(capture.CodeDir);

            for(var i=0; i<parts.Length; i++)
            {
                var part = parts[i];
                var data = archive.Read(part).ToArray();
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
        ICaptureArchive CaptureArchive(PartId part)
            => DataSource.CaptureArchive(
                (Env.Current.LogDir + FolderName.Define("apps")) + FolderName.Define(part.Format()), 
                FolderName.Define("capture"));

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root)
            => DataSource.CaptureArchive(root, null, null);

        [MethodImpl(Inline)]
        FilePath AsmFilePath<T>(PartId part) 
            => CaptureArchive(part).AsmPath<T>();

        [MethodImpl(Inline)]
        FilePath HexFilePath<T>(PartId part) 
            => CaptureArchive(part).HexPath<T>();

        [MethodImpl(Inline)]
        IEncodedHexArchive UriBitsArchive(FolderPath root)
            => DataSource.HexArchive(root);
    }
}