//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct MachineFiles : IMachineFiles
    {            
        [MethodImpl(Inline)]
        public MachineFiles(IMachineContext context)
        {
            this.Context = context;
            this.Archive = context.Archive;
        }

        public IMachineContext Context {get;}
        
        public ICaptureArchive Archive {get;}
    }
}