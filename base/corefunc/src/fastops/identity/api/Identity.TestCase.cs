//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    partial class Identity
    {
        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, IFunc f)
            => $"{host.Name}/{f.Moniker}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="m">Moniker that identifies the operation under test</param>
        public static string testcase(Type host, OpIdentity m)
            => $"{host.Name}/{m}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string testcase(Type host,string fullname)
            => $"{host.Name}/{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        public static string testcase<C>(Type host, string root, C t = default)
            where C : unmanaged
            => $"{host.Name}/{root}_{Identity.numericid(t)}";

        public static string testcase<W,C>(Type host, string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeNat
            where C : unmanaged
                => $"{host.Name}/{operation(root, (FixedWidth)w.NatValue, Numeric.kind<C>(), generic)}";
    }

}