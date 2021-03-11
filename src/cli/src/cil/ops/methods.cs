//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static memory;

    partial struct Cil
    {
        public static Index<CilMethod> methods(MethodInfo[] src)
        {
            var count = src.Length;
            var buffer = alloc<CilMethod>(count);
            var methods = @readonly(src);
            var target = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var address = ApiJit.jit(method);
                var located = new LocatedMethod(method.Identify(), method, address);
                var uri = OpUri.located(method.DeclaringType.HostUri(), method.Name, method.Identify());
                var body = method.GetMethodBody();
                var sig = method.ResolveSignature();
                if(body != null)
                {
                    var ilbytes = body.GetILAsByteArray() ?? Array.Empty<byte>();
                    var length = ilbytes.Length;
                    seek(target,i) = new CilMethod(method.MetadataToken, address, uri, sig, ilbytes, method.MethodImplementationFlags);
                }
            }

            return buffer;
        }
    }
}