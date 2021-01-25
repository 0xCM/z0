//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Security;

    using static Part;
    using static z;

    [ApiHost(ApiNames.ApiJit)]
    public readonly struct ApiJit
    {
        public static IApiJit service(IWfShell wf)
            => ApiJitService.create(wf);

        [Op]
        public static MemoryAddress jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        // [Op]
        // public static ApiMembers jit(IPart src)
        // {
        //     var dst = root.list<ApiMember>();
        //     var catalog = ApiCatalogs.create(src);
        //     var types = catalog.ApiTypes;
        //     var hosts = catalog.ApiHosts;

        //     foreach(var t in types.Storage)
        //         dst.AddRange(ApiJit.jit(t));
        //     foreach(var h in hosts.Storage)
        //         dst.AddRange(ApiJit.jit(h).Storage);

        //     return dst.ToArray();
        // }


        // [Op]
        // public static ApiMembers jit(IApiHost src)
        // {
        //     var direct = ApiJit.JitDirect(src);
        //     var generic = ApiJit.JitGeneric(src);
        //     var all = direct.Concat(generic).Array();
        //     return all.OrderBy(x => x.BaseAddress);
        // }

        // [Op]
        // public static ApiMember[] jit(ApiTypeInfo src)
        //     => ApiJit.jit(src, ApiTypeInfo.Ignore);

        // [Op]
        // public static ApiMember[] jit(ApiTypeInfo src, HashSet<string> exclusions)
        // {
        //     var methods = src.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions).Select(m => new HostedMethod(src.Uri, m));
        //     var located = methods.Select(m => m.WithLocation(memory.address(ApiJit.Jit(m.Method))));
        //     Array.Sort(located);
        //     return members(located);
        // }

        // [Op]
        // public static ApiMember[] jit(Index<ApiTypeInfo> src)
        // {
        //     var dst = root.list<ApiMember>();
        //     var count = src.Count;
        //     var exclusions = ApiTypeInfo.Ignore;
        //     ref var lead = ref src.First;
        //     for(var i=0u; i<count; i++)
        //         dst.AddRange(ApiJit.jit(skip(lead,i), exclusions));
        //     var collected = dst.ToArray();
        //     Array.Sort(collected);
        //     return collected;
        // }

        // [Op]
        // public static ApiMember[] members(HostedMethod[] located)
        // {
        //     var count = located.Length;
        //     var dst = sys.alloc<ApiMember>(count);
        //     for(var i=0; i<count; i++)
        //     {
        //         var member = located[i];
        //         var method = member.Method;
        //         var kind = method.KindId();
        //         var id = Diviner.Identify(method);
        //         var uri = ApiIdentity.uri(ApiUriScheme.Located, member.Host, method.Name, id);
        //         dst[i] = new ApiMember(uri,method, kind, member.Location);
        //     }

        //     return dst;
        // }

        // [Op]
        // internal static ApiMember[] JitDirect(IApiHost src)
        //     =>  from m in ApiQuery.DirectMethods(src)
        //         let kid = m.Method.KindId()
        //         let id = Diviner.Identify(m.Method)
        //         let uri = ApiIdentity.uri(ApiUriScheme.Located, src.Uri, m.Method.Name, id)
        //         let address = z.address(Jit(m.Method))
        //         select new ApiMember(uri, m.Method, kid, address);

        // internal static ApiMember[] JitGeneric(IApiHost src)
        // {
        //     var generic = @readonly(ApiQuery.GenericMethods(src));
        //     var gCount = generic.Length;
        //     var buffer = list<ApiMember>();
        //     for(var i=0; i<gCount; i++)
        //         buffer.AddRange(ApiJit.JitGeneric(skip(generic,i)));
        //     return buffer.ToArray();
        // }

        // [Op]
        // internal static ApiMember[] JitGeneric(HostedMethod src)
        // {
        //     var method = src.Method;
        //     var types = @readonly(ApiQuery.NumericClosureTypes(method));
        //     var count = types.Length;
        //     var buffer = alloc<ApiMember>(count);
        //     var dst = span(buffer);
        //     var @class = method.KindId();
        //     try
        //     {
        //         for(var i=0u; i<count; i++)
        //         {
        //             ref readonly var t = ref skip(types, i);
        //             var reified = src.Method.MakeGenericMethod(t);
        //             var address = z.address(Jit(reified));
        //             var id = Diviner.Identify(reified);
        //             var uri = ApiIdentity.uri(ApiUriScheme.Located, src.Host, method.Name, id);
        //             seek(dst,i) = new ApiMember(uri, reified, @class, address);
        //         }
        //     }
        //     catch(ArgumentException e)
        //     {
        //         var msg = string.Format("{0}: Closure creation failed for {1}/{2}", e.GetType().Name, method.DeclaringType.DisplayName(), method.DisplayName());
        //         term.warn(msg);
        //         return sys.empty<ApiMember>();
        //     }
        //     catch(Exception e)
        //     {
        //         term.warn(e.ToString());
        //     }
        //     return buffer;
        // }

        // internal static IMultiDiviner Diviner
        //     => MultiDiviner.Service;

        // [Op, MethodImpl(Inline)]
        // internal static IntPtr Jit(MethodInfo src)
        // {
        //     RuntimeHelpers.PrepareMethod(src.MethodHandle);
        //     return src.MethodHandle.GetFunctionPointer();
        // }
    }
}