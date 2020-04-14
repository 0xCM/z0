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
        const char Sep = UriDelimiters.PathSep;

        protected static OpIdentity SubjectId<T>(string opname, T t = default)
            where T : unmanaged
                => Identify.NumericOp(opname, NumericKinds.kind<T>());

        protected static OpIdentity BaselineId<K>(string opname,K t = default)
            where K : unmanaged
                => Identify.sfunc<K>($"{opname}_baseline");

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, ISFuncApi f)
            => $"{Identify.owner(host)}{Sep}{host.Name}{Sep}{f.Id}";

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public string CaseName(ISFuncApi f)
            => testcase(GetType(),f);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Moniker that identifies the operation under test</param>
        public string CaseName(OpIdentity id)
            => OpUriBuilder.TestCase(GetType(), id);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public string CaseName(string fullname)
            => OpUriBuilder.TestCase(GetType(), fullname);

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
            => OpUriBuilder.TestCase(GetType(),root, t);

        protected string CaseName<W,C>(string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => OpUriBuilder.TestCase(GetType(), root, w, t, generic);
    }
}