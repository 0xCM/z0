//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiReflected : IApiReflected
    {
        public static IApiReflected Service => default(ApiReflected);
    }    
}