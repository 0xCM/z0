//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class ServiceFactory
    {
        public static ICheckSVF<T> Decomposer<T>(this ITestContext context)
            where T : unmanaged
             => new SVValidatorD<T>(context);

        public static ICheckSFCells Decomposer(this ITestContext context)
            => new CheckDecomposition(context);
    }
}