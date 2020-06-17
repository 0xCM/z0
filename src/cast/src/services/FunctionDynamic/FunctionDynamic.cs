//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct FunctionDynamic : IFunctionDynamic
    {
        public static IFunctionDynamic Service => default(FunctionDynamic);
    }    
}