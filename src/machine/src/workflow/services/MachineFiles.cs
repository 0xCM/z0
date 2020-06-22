//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly struct MachineFiles : IMachineFiles
    {            
        [MethodImpl(Inline)]
        public static MachineFiles Service(IMachineContext context)
            => new MachineFiles(context);

        [MethodImpl(Inline)]
        public MachineFiles(IMachineContext context)
        {
            this.Context = context;
            this.Archive = context.Archive;
        }

        public IMachineContext Context {get;}
        
        public TCaptureArchive Archive {get;}
    }
}