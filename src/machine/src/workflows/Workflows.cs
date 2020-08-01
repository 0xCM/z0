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
        readonly Wf Context;
        
        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        readonly CorrelationToken Correlation;

        [MethodImpl(Inline), Op]
        public static Workflows create(Wf context, params string[] args)
            => new Workflows(context, args);

        [MethodImpl(Inline)]
        Workflows(Wf context, string[] args, params ActorIdentity[] known)     
        {
            Context = context;
            Args = args;
            Known = known;
            Correlation =  CorrelationToken.define(1ul);
            Context.Running(nameof(Workflows), Correlation);
        }
        
        [MethodImpl(Inline), Op]
        public MachineWorkflows Machine()
            => new MachineWorkflows(Context, Correlation, Args);

        public void Dispose()
        {
            Context.Ran(nameof(Workflows), Correlation);
        }
    }
}