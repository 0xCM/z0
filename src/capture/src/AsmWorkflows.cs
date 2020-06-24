//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;

    public readonly struct AsmWorkflows : TAsmWorkflows
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static TAsmWorkflows Service(IAsmContext context) 
            => new AsmWorkflows(context);

        [MethodImpl(Inline)]
        internal AsmWorkflows(IAsmContext context) 
            => Context = context;
    }
}