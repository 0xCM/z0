//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct CheckVectorBits : ICheckVectorBits, IValidator<CheckVectorBits,ICheckVectorBits>
    {
        public static ICheckVectorBits Checker => default(CheckVectorBits);
    }
}