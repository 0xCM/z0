//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;


    public readonly struct ApiMemberCollect
    {
        static IMultiDiviner Diviner 
            => MultiDiviner.Service;      

        static bool IsDirectApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && !src.AcceptsImmediate();

        static bool IsGenericApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && src.Tagged<ClosuresAttribute>() && !src.AcceptsImmediate();

        [MethodImpl(Inline)]
        static IntPtr Jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        static MethodInfo[] nongeneric(IApiHost src)
            => src.HostType.DeclaredMethods().NonGeneric().Where(IsDirectApiMember);

        static OpIdentity identify(MethodInfo src)
            => Diviner.Identify(src);
        
        static ApiMember[] JitLocatedDirect(IApiHost src, IAppEventSink sink)
        {
            var methods = span(nongeneric(src));
            var count = methods.Length;
            var buffer = alloc<ApiMember>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                var method = skip(methods,i);
                var uri = OpUri.Define(OpUriScheme.Located, src.Uri, method.Name, identify(method));
                var address = z.address(Jit(method));
                var kind = method.KindId();
                seek(dst,i) = new ApiMember(uri, method, kind, address);
            }

            return buffer;
        }
    }
}