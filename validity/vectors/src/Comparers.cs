//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class SFMatchServices
    {
        public static ISVValidatorD<T> Decomposer<T>(this ITestContext context)
            where T : unmanaged
             => new SVValidatorD<T>(context);

        public static ISVValidatorD Decompostions(this ITestContext context)
            => new SVValidatorD(ValidationContext.From(context));
            

    }
}