//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    
    using static Konst;
    using static Memories;
    using static TestCaseIdentity;
    using static UriDelimiters;

    public readonly struct TestCaseIdentity : ITestCaseIdentity
    {
        public static ITestCaseIdentity Service => default(TestCaseIdentity);

        internal static string Name(IFunc f)
            => Control.ifempty(f.GetType().Tag<OpKindAttribute>().MapValueOrDefault(a => a.Name), f.GetType().DisplayName());
        
        internal const char Sep = UriDelimiters.PathSep;

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        [MethodImpl(Inline)]   
        internal static string owner(Type host)
            => host.Assembly.Id().Format();
    }
            
    public interface ITestCaseIdentity : IValidator
    {
        /// <summary>
        /// Produces a test case name predicated on an operation identity
        /// </summary>
        /// <param name="id">Identifies the operation under test</param>
        string CaseName(OpIdentity id)
            => OpUriBuilder.TestCase(HostType, id);

        string CaseName([Caller] string label = null)
            => OpUriBuilder.TestCase(HostType, label);

        /// <summary>
        /// Produces a test case identifier predicated on a parametrically-specialized label
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        OpIdentity CaseOpId<T>([Caller] string label = null)
            where T : unmanaged
                => Identify.NumericOp($"{label}", typeof(T).NumericKind());
        
        /// <summary>
        /// Produces a test case name predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        string CaseName<T>([Caller] string label = null)
            where T : unmanaged
                => CaseName(CaseOpId<T>(label));

        OpIdentity BaselineId<K>(string label, K t = default)
            where K : unmanaged
                => Identify.sfunc<K>($"{label}_baseline");

        string CaseName(IFunc f) 
            =>$"{owner(HostType)}{Sep}{HostType.Name}{Sep}{Name(f)}";

        string CaseName<W,T>(IFunc f)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => CaseName<W,T>(HostType, Identify.Op<W,T>(Name(f)), true);

        string CaseName<W,T>([Caller] string label = null, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => CaseName<W,T>(GetType(), label, generic);

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="label">The root name</param>
        string CaseName<C>(Type host, string label)
            where C : unmanaged
                => text.concat(Identify.Owner(host), PathSep, host.Name, PathSep, label, '_', Identify.numeric<C>());

        string CaseName<W,C>(Type host, string label, bool generic)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => $"{Identify.Owner(host)}/{host.Name}{PathSep}{Identify.Op(label, default(W).TypeWidth, NumericKinds.kind<C>(), generic)}";

        /// <summary>
        /// Computes a test case identifier for a segmented structured function
        /// </summary>
        /// <param name="f">The function under test</param>
        /// <param name="w">The domainant operand width</param>
        /// <param name="generic">Whether the test subject is generic</param>
        /// <typeparam name="W">The type width</typeparam>
        /// <typeparam name="T">The cell width</typeparam>
        string CaseName<W,T>(IFunc f, W w, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => CaseName<W,T>(HostType, Identify.Op<W,T>(Name(f)), generic: generic);

        /// <summary>
        /// Produces a case name for an identified operation match test
        /// </summary>
        /// <param name="f">The left operation</param>
        /// <param name="g">The right operation</param>
        string MatchCaseName(OpIdentity f, OpIdentity g)
            => CaseName($"{f.IdentityText}_vs_{g.IdentityText}");
    }
}