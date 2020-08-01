//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public ref struct Workflows
    {        
        readonly MachineContext Context;
        
        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        long Correlation;

        [MethodImpl(Inline), Op]
        public static Workflows create(MachineContext context, params string[] args)
            => new Workflows(context, args);

        [MethodImpl(Inline)]
        Workflows(MachineContext context, string[] args, params ActorIdentity[] known)     
        {
            Context = context;
            Args = args;
            Known = known;
            Correlation =  0;
            Context.ContextRoot.Controlling(nameof(Workflows));
        }
        
        [MethodImpl(Inline), Op]
        public MachineWorkflows Machine()
            => new MachineWorkflows(Context, Args);

        public void Dispose()
        {
            Context.ContextRoot.Controlled(nameof(Workflows));
        }
    }
}