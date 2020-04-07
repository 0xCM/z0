//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class Identify
    {
        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        public static string testcase(Type host, OpIdentity id)
            => $"{owner(host)}{Sep}{host.Name}{Sep}{id}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        public static string testcase(MethodInfo method)
            => $"{owner(method.DeclaringType)}{Sep}{method.DeclaringType.Name}{Sep}{method.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string testcase(Type host, string fullname)
            => $"{owner(host)}{Sep}{host.Name}{Sep}{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        public static string testcase<C>(Type host, string root, C t = default)
            where C : unmanaged
                =>  text.concat(owner(host), Sep, host.Name, Sep, root, '_', numeric(t));

        public static string testcase<W,C>(Type host, string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => $"{owner(host)}{host.Name}/{Op(root, w.TypeWidth, NumericKinds.kind<C>(), generic)}";

        const char Sep = UriDelimiters.FS;

    }
}