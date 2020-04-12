//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class SFMatchServices
    {
        public static ISVFDecomposer<T> Decomposer<T>(this ITestContext context)
            where T : unmanaged
             => new SVValidatorD<T>(context);

        public static ISVFDecomposer Decomposer(this ITestContext context)
            => new SVFDecomposer(ValidationContext.From(context));            

    }
}