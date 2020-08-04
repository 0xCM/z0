//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using Z0.Asm;
    using Z0.Asm.Data;

    using static Konst;
    using static Root;

    [ApiHost]
    public readonly struct CodeRunner : IApiHost<CodeRunner>
    {
        [MethodImpl(Inline)]
        public static CodeRunner Service(IAsmContext context)
            => new CodeRunner(context);

        readonly IAsmContext Context;

        IApiSet Api
        {
            [MethodImpl(Inline)]
            get => Context.ContextRoot;
        }

        [MethodImpl(Inline)]
        public CodeRunner(IAsmContext context)
        {
            Context = context;
        }

        [Op]
        public void Run()
        {
            var parts = Api.PartIdentities.ToReadOnlySpan();
            for(var i=0; i<parts.Length; i++)
            {
                var part = skip(parts,i);
                term.magenta("Running part", part);
            }
        }
    }
}