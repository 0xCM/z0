//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public readonly struct TestCaseIdentity : ITestCaseIdentity
    {
        public static ITestCaseIdentity Service => default(TestCaseIdentity);

        public static string name(IFunc f)
            => ApiTestIdentity.name(f);

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        internal static string owner(Type host)
            => ApiTestIdentity.owner(host);

        public static string name(Type host, [Caller] string label = null)
            => ApiTestIdentity.name(host, label);

        public static string name(Type host, IFunc f)
            => ApiTestIdentity.name(host,f);

        /// <summary>
        /// Produces a test case identifier predicated on a parametrically-specialized label
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static OpIdentity id<T>([Caller] string label = null)
            where T : unmanaged
                => ApiTestIdentity.id<T>(label);

        /// <summary>
        /// Produces a test case name predicated on an operation identity
        /// </summary>
        /// <param name="id">Identifies the operation under test</param>
        public static string name(Type host, OpIdentity id)
            => ApiTestIdentity.name(host, id);

        /// <summary>
        /// Produces a test case name predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static string name<T>(Type host, [Caller] string label = null)
            where T : unmanaged
                => ApiTestIdentity.name<T>(host,label);

        /// <summary>
        /// Produces a case name for an identified operation match test
        /// </summary>
        /// <param name="f">The left operation</param>
        /// <param name="g">The right operation</param>
        public static string match(Type host, OpIdentity f, OpIdentity g)
            => ApiTestIdentity.match(host,f,g);

        public static string name<W,C>(Type host, string label, bool generic)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => ApiTestIdentity.name<W,C>(host,label,generic);
    }
}