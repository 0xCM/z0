//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IOperationChecker : IClaimValidator
    {
        OpUri Operation {get;}
    }

    public interface IEquatableChecker : IOperationChecker
    {
        CheckResult Eq<T>(T lhs, T rhs)
            where T : IEquatable<T>;
    }
}