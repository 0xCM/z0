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

    using Dn = dnlib.DotNet;
    using R = System.Reflection;

    using static Konst;
    using static z;

    partial struct Cil
    {
        public static CilFunction[] functions(R.Module module, LocatedMethod[] src)
        {
            var count = src.Length;
            var buffer = z.alloc<CilFunction>(count);
            var dst = span(buffer);
            var methods = @readonly(src);
            var formatter = Cil.formatter();
            var lookup = Dn.ModuleDefMD.Load(module).GetTypes().SelectMany(t => t.Methods).Select(m => ((uint)m.MDToken.Raw, m)).ToDictionary();

            for(var i=0u; i<count; i++)
            {
                ref readonly var srcMethod = ref skip(methods,i);
                var _m = srcMethod.Method;
                var token = (uint)_m.MetadataToken;
                if(lookup.TryGetValue(token, out var dnMethod))
                {
                    ref var target = ref seek(dst,i);
                    target.Key = _m.MetadataToken;
                    target.FullName = dnMethod.FullName;
                    target.Attributes = _m.MethodImplementationFlags;
                    target.Encoded = _m.GetMethodBody().GetILAsByteArray();
                    target.Instructions = dnMethod.Body.Instructions.Map(describe);
                    target.BaseAddress = srcMethod.Address;
                    target.Identifier = srcMethod.Id;
                    target.Formatted = formatter.Format(target);
                    dnMethod.FreeMethodBody();
                }
            }

            return buffer;
        }

        public static CilFunction? decode(R.MethodInfo src)
        {
            var mod = src.DeclaringType.Module;
            var dnMod = Dn.ModuleDefMD.Load(mod);
            var types = dnMod.GetTypes();
            foreach(var tDef in types)
            {
                foreach(var mDef in tDef.Methods)
                {
                    if(!mDef.HasBody || !mDef.Body.HasInstructions)
                        continue;

                    var token = mDef.MDToken.Raw;
                    if(token == src.MetadataToken)
                    {
                        var cil = new CilFunction((int)token, mDef.FullName, (R.MethodImplAttributes)mDef.ImplAttributes, mDef.Body.Instructions.Map(describe));
                        mDef.FreeMethodBody();
                        return cil;
                    }
                }
            }
            return null;
        }

        public static IEnumerable<CilFunction> decode(R.Module module, params MethodInfo[] src)
        {
            var dnMod = Dn.ModuleDefMD.Load(module);
            var types = dnMod.GetTypes();
            var lookup = src.Select(x => ((uint)x.MetadataToken, x)).ToDictionary();

            foreach(var tDef in types)
            {
                foreach(var mDef in tDef.Methods)
                {
                    if(!mDef.HasBody || !mDef.Body.HasInstructions)
                        continue;

                    var token = mDef.MDToken.Raw;
                    if(lookup.ContainsKey(token))
                    {
                        var fx = new CilFunction(token, mDef.FullName, (R.MethodImplAttributes)mDef.ImplAttributes, mDef.Body.Instructions.Map(describe));
                        mDef.FreeMethodBody();
                        yield return fx;
                    }
                }
            }
        }
    }
}