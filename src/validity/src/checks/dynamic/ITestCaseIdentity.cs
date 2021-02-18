//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static SFx;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public interface ITestCaseIdentity : IClaimValidator
    {
        /// <summary>
        /// Produces a test case name predicated on an operation identity
        /// </summary>
        /// <param name="id">Identifies the operation under test</param>
        string CaseName(OpIdentity id)
            => TestCaseIdentity.service(HostType).CaseName(id);

        /// <summary>
        /// Produces a test case name predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        string CaseName<T>([Caller] string label = null)
            where T : unmanaged
                => TestCaseIdentity.service(HostType).CaseName<T>(label);

        string CaseName<W,T>(IFunc f)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => TestCaseIdentity.service(HostType).CaseName<W,T>(f);

        string CaseName<W,T>([Caller] string label = null, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => TestCaseIdentity.service(HostType).CaseName<W,T>(HostType, label, generic);

        string CaseName<W,C>(Type host, string label, bool generic)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => TestCaseIdentity.service(HostType).CaseName<W,C>(host, label, generic);

        /// <summary>
        /// Produces a case name for an identified operation match test
        /// </summary>
        /// <param name="f">The left operation</param>
        /// <param name="g">The right operation</param>
        string MatchCaseName(OpIdentity f, OpIdentity g)
            => TestCaseIdentity.service(HostType).MatchCaseName(f, g);
    }
}