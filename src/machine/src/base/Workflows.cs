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
        readonly IAppContext Context;

        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        long Correlation;

        [MethodImpl(Inline), Op]
        public static Workflows create(IAppContext context, params string[] args)
            => new Workflows(context, args);

        [MethodImpl(Inline)]
        Workflows(IAppContext context, string[] args, params ActorIdentity[] known)     
        {
            term.print($"Running worklfows");            
            Context = context;
            Args = args;
            Known = known;
            Correlation =  0;
        }
        
        [MethodImpl(Inline), Op]
        public MachineWorkflows Machine()
        {
            return new MachineWorkflows(Context, Args);
        }

        public void Dispose()
        {
            term.print($"Ran workflows");
        }
    }
}