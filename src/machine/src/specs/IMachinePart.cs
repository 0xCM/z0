//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IMachinePart : IMachineService
    {
        
    }

    readonly struct MachinePart : IMachinePart
    {
        [MethodImpl(Inline)]
        public static IMachinePart Create(IMachineContext context)
            => new MachinePart(context);

        [MethodImpl(Inline)]
        MachinePart(IMachineContext context)
        {
            Context = context;
        }

        public IMachineContext Context {get;}
    }

}