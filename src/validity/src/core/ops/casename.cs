//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    partial class TestContext<U>
    {
        protected static OpIdentity SubjectId<T>(string opname, T t = default)
            where T : unmanaged
                => TestCaseNaming.SubjectId<T>(opname);
                
        protected static OpIdentity BaselineId<K>(string opname,K t = default)
            where K : unmanaged
                => TestCaseNaming.SFuncBaseline<K>(opname);

        public string CaseName(string label)
            => Context.CaseName(label);

        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
                => Context.CaseName<C>(root);

        protected string CaseName<W,C>(string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => Context.CaseName<W,C>(root, generic: generic);

        protected string CaseName(ISFuncApi f) 
            => Context.CaseName(f);
    }
}