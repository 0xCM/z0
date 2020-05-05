//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    readonly struct MachineContext : IMachineContext
    {
        readonly IAsmContext AsmContext;

        public PartId[] CodeParts {get;}
        
        public ICaptureArchive Archive {get;}

        public IAppMsgSink AppMsgSink => AsmContext;

        [MethodImpl(Inline)]
        public static IMachineContext Create(IAsmContext src, PartId[] code)
            => new MachineContext(src,code);
        
        internal MachineContext(IAsmContext src, PartId[] code)
        {                        
            CodeParts = code.Length == 0 ? Enums.literals<PartId>().Map(x => x.Value) : code;
            AsmContext = src;
            var archiveRoot = src.AppPaths.ForApp(PartId.Control).AppCapturePath;
            Archive = Archives.Services.CaptureArchive(archiveRoot);
        }
    }
}