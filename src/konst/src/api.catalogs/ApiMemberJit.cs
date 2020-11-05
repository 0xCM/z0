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

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiJit)]
    public readonly struct ApiJit
    {
        [MethodImpl(Inline)]
        public static MemoryAddress jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [Op]
        public static ApiMembers jit(IApiHost src)
        {
            var direct = JitDirect(src);
            var generic = _JitGeneric(src);
            var all = direct.Concat(generic).Array();
            return all.OrderBy(x => x.Address);
        }

        [Op]
        public static ApiMember[] jit(ApiDataType src)
            => jit(src, ApiDataType.Ignore);

        [Op]
        public static ApiMember[] jit(ApiDataType src, HashSet<string> exclusions)
        {
            var methods = src.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions).Select(m => new HostedMethod(src.Uri, m));
            var located = methods.Select(m => m.WithLocation(z.address(Jit(m.Method))));
            Array.Sort(located);
            return members(located);
        }

        [Op]
        public static ApiMember[] jit(ApiDataTypes src)
        {
            var dst = z.list<ApiMember>();
            var count = src.Count;
            var exclusions = ApiDataType.Ignore;
            ref var lead = ref src.LeadingCell;

            for(var i=0u; i<count; i++)
                dst.AddRange(jit(skip(lead,i), exclusions));

            var collected = dst.ToArray();
            Array.Sort(collected);
            return collected;
        }

        [Op]
        public static ApiMember[] members(HostedMethod[] located)
        {
            var count = located.Length;
            var dst = sys.alloc<ApiMember>(count);
            for(var i=0; i<count; i++)
            {
                var member = located[i];
                var method = member.Method;
                var kind = method.KindId();
                var id = Diviner.Identify(method);
                var uri = OpUri.Define(ApiUriScheme.Located, member.Host, method.Name, id);
                dst[i] = new ApiMember(uri,method, kind, member.Location);
            }

            return dst;
        }

        [Op]
        static ApiMember[] JitDirect(IApiHost src)
            =>  from m in ApiQuery.DirectMethods(src)
                let kid = m.Method.KindId()
                let id = Diviner.Identify(m.Method)
                let uri = OpUri.Define(ApiUriScheme.Located, src.Uri, m.Method.Name, id)
                let address = z.address(Jit(m.Method))
                select new ApiMember(uri, m.Method, kid, address);

        static ApiMember[] _JitGeneric(IApiHost src)
        {
            var generic = @readonly(ApiQuery.GenericMethods(src));
            var gCount = generic.Length;
            var buffer = list<ApiMember>();
            for(var i=0; i<gCount; i++)
            {
                buffer.AddRange(reify(skip(generic,i)));
            }
            return buffer.ToArray();
        }

        [Op]
        static ApiMember[] reify(HostedMethod src)
        {
            var method = src.Method;
            var types = @readonly(ApiQuery.NumericClosureTypes(method));
            var count = types.Length;
            var buffer = alloc<ApiMember>(count);
            var dst = span(buffer);
            var @class = method.KindId();
            try
            {
                for(var i=0u; i<count; i++)
                {
                    ref readonly var t = ref skip(types, i);
                    var reified = src.Method.MakeGenericMethod(t);
                    var address = z.address(Jit(reified));
                    var id = Diviner.Identify(reified);
                    var uri = OpUri.Define(ApiUriScheme.Located, src.Host, method.Name, id);
                    seek(dst,i) = new ApiMember(uri, reified, @class, address);
                }
            }
            catch(Exception e)
            {
                term.warn(string.Format("Attempt to create closures over the source method {0} dit not go as anticipated: {1}", method.Name, e));
                return sys.empty<ApiMember>();
            }
            return buffer;
        }

        [Op]
        static ApiMember[] JitGeneric(IApiHost src)
            =>  (from m in ApiQuery.GenericMethods(src)
                let kid = m.Method.KindId()
                from t in ApiQuery.NumericClosureTypes(m.Method)
                let reified = m.Method.MakeGenericMethod(t)
                let address = z.address(Jit(reified))
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(ApiUriScheme.Located, src.Uri, m.Method.Name, id)
                select new ApiMember(uri, reified, kid, address)).Array();

        static IMultiDiviner Diviner
            => MultiDiviner.Service;

        [Op, MethodImpl(Inline)]
        static IntPtr Jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }
    }
}