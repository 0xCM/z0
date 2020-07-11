//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MachineFiles : IMachineFileArchive
    {            
        [MethodImpl(Inline)]
        public static MachineFiles Service(IMachineContext context)
            => new MachineFiles(context);

        [MethodImpl(Inline)]
        public MachineFiles(IMachineContext context)
        {
            this.Context = context;
            this.CaptureArchive = context.Archive;
        }

        public IMachineContext Context {get;}
        
        public TPartCaptureArchive CaptureArchive {get;}
    }




}