//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct CheckDynamic : ICheckDynamic
    {
        public static ICheckDynamic Checker => default(CheckDynamic);
    }

    public interface ICheckDynamic : IValidator
    {
        IDynamicOps Dynamic => IContext.Default.Dynamic();
    }
}