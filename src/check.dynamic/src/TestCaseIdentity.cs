//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static UriDelimiters;

    public readonly struct TestCaseIdentity : TTestCaseIdentity
    {
        public static TTestCaseIdentity Service => default(TestCaseIdentity);

        public static string name(IFunc f)
            => Root.ifempty(f.GetType().Tag<OpKindAttribute>()
                   .MapValueOrDefault(a => f.GetType().DisplayName(), f.GetType().DisplayName()),  f.GetType().DisplayName());

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        internal static string owner(Type host)
            => host.Assembly.Id().Format();

        public static string name(Type host, [Caller] string label = null)
            => ApiUri.TestCase(host, label);

        public static string name(Type host, IFunc f)
            =>$"{owner(host)}{UriPathSep}{host.Name}{UriPathSep}{name(f)}";

        /// <summary>
        /// Produces a test case identifier predicated on a parametrically-specialized label
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static OpIdentity id<T>([Caller] string label = null)
            where T : unmanaged
                => ApiIdentityKinds.NumericOp($"{label}", typeof(T).NumericKind());

        /// <summary>
        /// Produces a test case name predicated on an operation identity
        /// </summary>
        /// <param name="id">Identifies the operation under test</param>
        public static string name(Type host, OpIdentity id)
            => ApiUri.TestCase(host, id);

        /// <summary>
        /// Produces a test case name predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static string name<T>(Type host, [Caller] string label = null)
            where T : unmanaged
                => ApiUri.TestCase(host, id<T>(label));

        /// <summary>
        /// Produces a case name for an identified operation match test
        /// </summary>
        /// <param name="f">The left operation</param>
        /// <param name="g">The right operation</param>
        public static string match(Type host, OpIdentity f, OpIdentity g)
            => ApiUri.TestCase(host, $"{f.Identifier}_vs_{g.Identifier}");

        public static string name<W,C>(Type host, string label, bool generic)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => $"{ApiIdentityKinds.OwningPartText(host)}/{host.Name}{UriPathSep}{ApiIdentityBuilder.build(label, default(W).TypeWidth, NumericKinds.kind<C>(), generic)}";
    }
}