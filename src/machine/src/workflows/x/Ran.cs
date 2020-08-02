//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    partial class XTend
    {
        public static void Ran(this IAppContext context, string worker)
            => context.Deposit(new WfStepFinished(worker));            

        public static void Ran(this IAppContext context, string worker, string detail)
            => context.Deposit(new WfStepFinished(worker, detail));                        

        public static void Ran(this IAsmContext context, string worker)
            => context.Deposit(new WfStepFinished(worker));
    }
}