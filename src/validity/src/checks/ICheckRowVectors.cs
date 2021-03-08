//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ICheckRowVectors : IClaimValidator
    {
        static ICheckRowVectors<CheckRowVectors> Checker
            => default(CheckRowVectors);

        [MethodImpl(Inline)]
        int length<T>(RowVector256<T> lhs, RowVector256<T> rhs)
            where T : unmanaged
                => CheckRowVectors.length(lhs,rhs);
    }

    public interface ICheckRowVectors<C> : ICheckRowVectors
        where C : ICheckRowVectors<C>, new()
    {


    }
}