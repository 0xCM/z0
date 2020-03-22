//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public static class TestIdentity
    {
        const char Sep = UriDelimiters.FS;

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly
        /// and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        public static string hosturi(Type host)
            =>  $"{TypeIdentity.owner(host)}{Sep}{host.Name}";

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, IFunc f)
            => $"{TypeIdentity.owner(host)}{Sep}{host.Name}{Sep}{f.Id}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        public static string testcase(Type host, OpIdentity id)
            => $"{TypeIdentity.owner(host)}{Sep}{host.Name}{Sep}{id}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        public static string testcase(MethodInfo method)
            => $"{TypeIdentity.owner(method.DeclaringType)}{Sep}{method.DeclaringType.Name}{Sep}{method.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string testcase(Type host, string fullname)
            => $"{TypeIdentity.owner(host)}{Sep}{host.Name}{Sep}{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        public static string testcase<C>(Type host, string root, C t = default)
            where C : unmanaged
                =>  text.concat(TypeIdentity.owner(host), Sep, host.Name, Sep, root, '_', TypeIdentity.numeric(t));
    }
}