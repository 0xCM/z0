//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ApiUriDelimiters;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public readonly struct TestCaseIdentity : ITestCaseIdentity
    {
        public Type HostType {get;}

        public TestCaseIdentity(Type host)
            => HostType = host;

        /// <summary>
        /// Produces a test case name predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static string NumericName<T>(Type host, [Caller] string label = null)
            where T : unmanaged
                => from(host, ApiIdentityBuilder.NumericId<T>(label));

        /// <summary>
        /// Produces a test case identifier predicated on a parametrically-specialized label
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static OpIdentity NumericId<T>([Caller] string label = null)
            where T : unmanaged
                => ApiIdentityBuilder.numeric($"{label}", typeof(T).NumericKind());

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        [Op]
        public static string from(MethodInfo method)
            => $"{PartName.from(method.DeclaringType)}{UriPathSep}{method.DeclaringType.Name}{UriPathSep}{method.Name}";

        /// <summary>
        /// Produces a test case name predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static string name<T>(Type host, [Caller] string label = null)
            where T : unmanaged
                => NumericName<T>(host, label);

        public string name<W,T>([Caller] string label = null, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => ApiIdentityBuilder.name<W,T>(GetType(), label, generic);

        /// <summary>
        /// Produces a case name for an identified operation match test
        /// </summary>
        /// <param name="f">The left operation</param>
        /// <param name="g">The right operation</param>
        public string match(OpIdentity f, OpIdentity g)
             => match(HostType,f,g);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        [Op]
        public static string identify(Type host, string fullname)
            => $"{PartName.from(host)}{UriPathSep}{host.Name}{UriPathSep}{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        [Op]
        public static string from(OpUri uri)
            => $"{uri.Part.Format()}{UriPathSep}{uri.Host.HostName}{UriPathSep}{uri.OpId}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        [Op]
        public static string from(ApiHostUri host, OpIdentity id)
            => $"{host.Part.Format()}{UriPathSep}{host.HostName}{UriPathSep}{id}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, excluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        [Op]
        public static string from(Type host, OpIdentity id)
            => $"{PartName.from(host)}{UriPathSep}{host.Name}{UriPathSep}{id.IdentityText}";

        /// <summary>
        /// Produces a case name for an identified operation match test
        /// </summary>
        /// <param name="f">The left operation</param>
        /// <param name="g">The right operation</param>
        public static string match(Type host, OpIdentity f, OpIdentity g)
             => identify(host, $"{f.IdentityText}_vs_{g.IdentityText}");
   }
}