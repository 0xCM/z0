//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;
    using static Memories;

    public interface ITestCaseIdentity : IValidator
    {
        Type ValidatorType => GetType();

        /// <summary>
        /// Produces a test case name predicated on an operation identity
        /// </summary>
        /// <param name="id">Identifies the operation under test</param>
        string CaseName(OpIdentity id)
            => OpUriBuilder.TestCase(ValidatorType, id);

        string CaseName(string label)
            => OpUriBuilder.TestCase(ValidatorType, label);

        string CaseName(ISFuncApi f) 
            => TestCaseIdentity.sfunc(ValidatorType, f);

        string CaseName<W,T>(ISFuncApi f, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => OpUriBuilder.TestCase<W,T>(ValidatorType, Identify.Op<W,T>(f.Id.Name), generic: generic);

        string CaseName<W,T>(string root, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => OpUriBuilder.TestCase(GetType(), root, w, t, generic);

        /// <summary>
        /// Produces a case name for an identified operation match test
        /// </summary>
        /// <param name="f">The left operation</param>
        /// <param name="g">The right operation</param>
        string MatchCaseName(OpIdentity f, OpIdentity g)
            => CaseName($"{f.Identifier}_vs_{g.Identifier}");

        /// <summary>
        /// Produces a test case identifier predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="id">Identifies the operation under test</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        OpIdentity CaseOpId<T>(string label)
            where T : unmanaged
                => Identify.NumericOp($"{label}", typeof(T).NumericKind());
        
        /// <summary>
        /// Produces a test case name predicated on a parametrically-specialized label
        /// </summary>
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        string CaseName<T>(string label)
            where T : unmanaged
                => CaseName(CaseOpId<T>(label));
    }
}