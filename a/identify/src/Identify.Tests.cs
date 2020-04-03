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
        public static string TestCase(Type host, OpIdentity id)
            => $"{Identify.Owner(host)}{Sep}{host.Name}{Sep}{id}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        public static string TestCase(MethodInfo method)
            => $"{Identify.Owner(method.DeclaringType)}{Sep}{method.DeclaringType.Name}{Sep}{method.Name}";

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly
        /// and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        public static string HostUri(Type host)
            =>  $"{Identify.Owner(host)}{Sep}{host.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string TestCase(Type host, string fullname)
            => $"{Identify.Owner(host)}{Sep}{host.Name}{Sep}{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        public static string TestCase<C>(Type host, string root, C t = default)
            where C : unmanaged
                =>  text.concat(Identify.Owner(host), Sep, host.Name, Sep, root, '_', Identify.NumericType(t));

        public static string TestCase<W,C>(Type host, string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => $"{Identify.Owner(host)}{host.Name}/{Identify.Op(root, w.TypeWidth, NumericKinds.kind<C>(), generic)}";

        const char Sep = UriDelimiters.FS;
    }
}