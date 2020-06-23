//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;

    readonly struct MachineContext : IMachineContext
    {
        public IAsmContext AsmContext {get;}

        [MethodImpl(Inline)]
        public static IMachineContext Create(IAsmContext src, PartId[] code)
            => new MachineContext(src,code);

        public PartId[] Parts {get;}
        
        public TCaptureArchive Archive {get;}

        public IAppMsgSink AppMsgSink 
            => AsmContext;

        public IAsmFunctionDecoder Decoder 
            => AsmContext.Decoder;

        public IAsmFormatter Formatter 
            => AsmContext.Formatter;
        
        [MethodImpl(Inline)]
        internal MachineContext(IAsmContext src, PartId[] parts)
        {                        
            AsmContext = src;
            Parts = parts.Length == 0 ? Enums.index<PartId>().Where(x => x.LiteralValue != PartId.None).Map(x => x.LiteralValue) : parts;
            var archiveRoot = src.AppPaths.ForApp(PartId.Control).AppCaptureDir;
            Archive = Archives.Services.CaptureArchive(archiveRoot);            
        }
    }
}