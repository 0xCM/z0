//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static z;

    partial struct Cil
    {
        public static Index<FunctionInfo> decode(Module module, MethodInfo[] src)
        {
            var dst = list<FunctionInfo>(src.Length);
            var types = @readonly(module.GetTypes());
            var lookup = src.Select(x => ((uint)x.MetadataToken, x)).ToDictionary();
            var kTypes = types.Length;
            for(var i=0; i<kTypes; i++)
            {
                var methods = @readonly(skip(types,i).Methods());
                var kMethods = methods.Length;
                for(var j=0; j<kMethods; j++)
                {
                    ref readonly var method = ref skip(methods,j);
                    var token = (uint)method.MetadataToken;
                    var body = method.GetMethodBody();
                    if(body != null)
                    {
                        var data = body.GetILAsByteArray() ?? Array.Empty<byte>();
                        var length = data.Length;
                        if(length != 0)
                        {
                            if(lookup.ContainsKey(token))
                                dst.Add(new FunctionInfo(token, method.Name, method.MethodImplementationFlags));
                        }
                    }
                }
            }

            return dst.ToArray();
        }

        public static Index<Instruction> decode(ReadOnlySpan<byte> src)
        {
            var dst = list<Instruction>();
            var count = src.Length;
            ref readonly var source = ref first(src);
            for(var i=0; i<count; i++)
            {
                ref readonly var b = ref skip(source,i);
            }
            return dst.ToArray();
        }
    }
}