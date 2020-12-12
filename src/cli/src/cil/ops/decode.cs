//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct Cil
    {
        public static IEnumerable<CilFunctionInfo> decode(Module module, MethodInfo[] src)
        {
            var types = module.GetTypes();
            var lookup = src.Select(x => ((uint)x.MetadataToken, x)).ToDictionary();

            foreach(var type in types)
            {
                foreach(var method in type.Methods())
                {
                    var body = method.GetMethodBody();
                    if(body != null)
                    {
                        Index<byte> data = body.GetILAsByteArray();
                        if(data.IsNonEmpty)
                        {
                            var token = (uint)method.MetadataToken;
                            if(lookup.ContainsKey(token))
                            {
                                var fx = new CilFunctionInfo(token, method.Name, method.MethodImplementationFlags);
                                yield return fx;
                            }
                        }
                    }
                }
            }
        }
    }
}