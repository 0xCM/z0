//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public abstract class WfHost<H,S,T> : WfHost<H,S>, IWfHost<H,S,T>
        where H : WfHost<H,S,T>, new()
        where S : new()
    {
        [MethodImpl(Inline)]
        protected WfHost()
            : base()
        {

        }

        public static new H create()
            => new H();

        [MethodImpl(Inline)]
        public ref T Run(IWfRuntime wf, in S src, out T dst)
        {
            Execute(wf, src, out dst);
            return ref dst;
        }

        protected abstract ref T Execute(IWfRuntime wf, in S src, out T dst);
    }
}