//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Cil
    {
        public static FunctionInfo[] functions(Module module, LocatedMethod[] src)
        {
            var count = src.Length;
            var buffer = sys.alloc<FunctionInfo>(count);
            var dst = span(buffer);
            var methods = @readonly(src);
            var formatter = Cil.formatter();
            var lookup = module.GetTypes().SelectMany(t => t.Methods()).Select(m => ((uint)m.MetadataToken, m)).ToDictionary();

            for(var i=0u; i<count; i++)
            {
                ref readonly var srcMethod = ref skip(methods,i);
                var _m = srcMethod.Method;
                var token = (uint)_m.MetadataToken;
                if(lookup.TryGetValue(token, out var dnMethod))
                {
                    ref var target = ref seek(dst,i);
                    target.Key = _m.MetadataToken;
                    target.FullName = dnMethod.Name;
                    target.Attributes = _m.MethodImplementationFlags;
                    target.Encoded = _m.GetMethodBody().GetILAsByteArray();
                    target.Instructions = default;//dnMethod.Body.Instructions.Map(describe);
                    target.BaseAddress = srcMethod.Address;
                    target.Identifier = srcMethod.Id;
                    target.Formatted = formatter.Format(target);
                }
            }

            return buffer;
        }
    }
}