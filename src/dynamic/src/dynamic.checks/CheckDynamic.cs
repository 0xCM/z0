//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CheckDynamic : TCheckDynamic
    {
        public static TCheckDynamic Checker => default(CheckDynamic);
    }
}