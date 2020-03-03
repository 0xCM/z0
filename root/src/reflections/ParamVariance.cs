//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    public enum ParamVariance
    {
        None = 0, 

        In = 1,

        Out = 2,

        Ref = 3
    }

    public static class ParamVarianceOps
    {

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamVariance src)        
            => src != ParamVariance.None;


        public static string Keyword(this ParamVariance src)        
            => src switch{
                ParamVariance.In => "in",
                ParamVariance.Out => "out",
                ParamVariance.Ref => "ref",    
                _ => string.Empty
            };

        public static string Format(this ParamVariance src)
            => src.IsSome() ? ('~' + src.Keyword()) : string.Empty;      
    }
}