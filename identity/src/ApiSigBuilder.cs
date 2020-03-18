//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;


    public readonly struct ApiSigBuilder
    {
        public ParameterSig BuildSig(ParameterInfo src)
        {
            return default;
        }

        public ApiSig BuildSig(MethodInfo src)
        {

            var srcParams = src.GetParameters().ToArray();
            var paramCount = srcParams.Length;
            var dstParams = new ParameterSig[paramCount];
            for(var i=0; i<paramCount; i++)
                dstParams[i] = BuildSig(srcParams[i]);

            return ApiSig.Empty;
            
        }
    }

}