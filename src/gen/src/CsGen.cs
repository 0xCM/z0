//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static class XSvc
    {
        public static Generators Generators(this IWfRuntime wf)
            => Z0.Generators.create(wf);
    }
}