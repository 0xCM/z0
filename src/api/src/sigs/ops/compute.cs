//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct ApiSigs
    {
        public static OperationSig compute(MethodInfo src)
        {
            if(src.IsNonGeneric())
            {
                return default;

            }
            else if(src.IsClosedGeneric())
            {
                return default;

            }
            else if(src.IsOpenGeneric())
            {

                return default;
            }
            else
            {
                return @throw<OperationSig>($"Method classification error: {src}");
            }
        }
    }
}