//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost("api")]
    public partial class Seed : IApiHost<Seed>
    {
        public static void ThrowEmptySpanError()
            => throw new Exception($"The span is empty");
    }



    public static partial class XTend
    {

    }    
}