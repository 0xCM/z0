//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class Identity
    {
        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        public static string owner(Type host)
            => host.Assembly.AssemblyId().Format();

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, IFunc f)
            => $"{owner(host)}/{host.Name}/{f.Id}";

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly
        /// and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        public static string testhosturi(Type host)
            => $"{owner(host)}/{host.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        public static string testcase(Type host, OpIdentity id)
            => $"{owner(host)}/{host.Name}/{id}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        public static string testcase(MethodInfo method)
            => $"{owner(method.DeclaringType)}/{method.DeclaringType.Name}/{method.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string testcase(Type host,string fullname)
            => $"{owner(host)}{host.Name}/{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        public static string testcase<C>(Type host, string root, C t = default)
            where C : unmanaged
            => $"{owner(host)}{host.Name}/{root}_{TypeIdentity.numeric(t)}";

        public static string testcase<W,C>(Type host, string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeNat
            where C : unmanaged
                => $"{owner(host)}{host.Name}/{operation(root, (FixedWidth)w.NatValue, Numeric.kind<C>(), generic)}";
    }
}