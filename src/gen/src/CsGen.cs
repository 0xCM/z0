//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CsGen
    {
        public static EnumGen EnumGenerator => new();
    }


    public static class XSvc
    {
        public static Generators Generators(this IWfRuntime wf)
            => Z0.Generators.create(wf);
    }
}