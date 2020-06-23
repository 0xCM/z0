//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CheckDynamic : TCheckDynamic
    {
        public static TCheckDynamic Checker => default(CheckDynamic);
    }

    public interface TCheckDynamic : TValidator
    {
        IDynexus Dynamic => Dynops.Services.Dynexus;
    }
}