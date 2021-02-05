//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    [Service(typeof(IApiJit)), ApiHost]
    public sealed class ApiJit : WfService<ApiJit,IApiJit>, IApiJit
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress jit(ApiMember src)
        {
            RuntimeHelpers.PrepareMethod(src.Method.MethodHandle);
            return src.Method.MethodHandle.GetFunctionPointer();
        }

        [Op]
        public static MemoryAddress jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [Op]
        public static LocatedMethod jit(IdentifiedMethod src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return new LocatedMethod(src.Id, src.Method, (MemoryAddress)src.MethodHandle.GetFunctionPointer());
        }

        [Op]
        public LocatedMethod Jit(IdentifiedMethod src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return new LocatedMethod(src.Id, src.Method, (MemoryAddress)src.MethodHandle.GetFunctionPointer());
        }

        [Op]
        public static IntPtr jit(Delegate src)
        {
            RuntimeHelpers.PrepareDelegate(src);
            return src.Method.MethodHandle.GetFunctionPointer();
        }

        [Op]
        public static DynamicPointer jit(DynamicDelegate src)
        {
            RuntimeHelpers.PrepareDelegate(src.Operation);
            return ClrDynamic.pointer(src);
            //return ClrDynamic.pointer(src, ClrDynamic.pointer(src.Target));
        }

        [MethodImpl(Inline)]
        public static DynamicPointer jit<D>(DynamicDelegate<D> src)
            where D : Delegate
                => jit(src.Untyped);

        public BasedApiMembers JitApi()
        {
            var @base = Runtime.CurrentProcess.BaseAddress;
            var catalog = Wf.ApiParts.ApiGlobal;
            var parts = catalog.Parts;
            var kParts = parts.Length;
            var flow = Wf.Running(Msg.JittingParts.Format(kParts));
            var all = root.list<ApiMembers>();
            var total = 0u;
            foreach(var part in parts)
            {
                var subflow = Wf.Running(Msg.JittingPart.Format(part.Id));
                var partMembers = Jit(part);
                all.Add(partMembers);
                Wf.Ran(subflow, Msg.JittedPart.Format(partMembers.Length, part.Id));
            }

            var members = new BasedApiMembers(@base, all.SelectMany(x => x).OrderBy(x => x.BaseAddress).Array());
            Wf.Ran(flow, Msg.JittedParts.Format(members.MemberCount, parts.Length));
            return members;
        }

        public ApiMembers Jit(IApiHost src)
        {
            var direct = JitDirect(src);
            var generic = JitGeneric(src);
            var all = direct.Concat(generic).Array();
            return all.OrderBy(x => x.BaseAddress);
        }

        public ApiMember[] Jit(Index<ApiRuntimeType> src)
        {
            var dst = root.list<ApiMember>();
            var count = src.Count;
            var exclusions = Ignore;
            ref var lead = ref src.First;
            for(var i=0u; i<count; i++)
                dst.AddRange(Jit(skip(lead,i), exclusions));
            var collected = dst.ToArray();
            Array.Sort(collected);
            return collected;
        }

        public ApiMembers Jit(IPart src)
        {
            var dst = root.list<ApiMember>();
            var catalog = ApiCatalogs.part(src);
            var types = catalog.ApiTypes;
            var hosts = catalog.ApiHosts;

            foreach(var t in types.Storage)
                dst.AddRange(Jit(t));
            foreach(var h in hosts.Storage)
                dst.AddRange(Jit(h).Storage);

            return dst.ToArray();
        }

        public Index<ApiMember> Jit(ApiRuntimeType src)
            => Jit(src, Ignore);

        [Op]
        ApiMember[] Jit(ApiRuntimeType src, HashSet<string> exclusions)
        {
            var methods = src.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions).Select(m => new JittedMethod(src.Uri, m));
            var located = methods.Select(m => m.WithLocation(address(Jit(m.Method))));
            Array.Sort(located);
            return Members(located);
        }

        [Op]
        ApiMember[] Members(JittedMethod[] located)
        {
            var count = located.Length;
            var dst = sys.alloc<ApiMember>(count);
            for(var i=0; i<count; i++)
            {
                var member = located[i];
                var method = member.Method;
                var kind = method.KindId();
                var id = Diviner.Identify(method);
                var uri = ApiIdentity.uri(ApiUriScheme.Located, member.Host, method.Name, id);
                dst[i] = new ApiMember(uri,method, kind, member.Location);
            }

            return dst;
        }

        IMultiDiviner Diviner
            => MultiDiviner.Service;

        [Op]
        IntPtr Jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [Op]
        ApiMember[] JitDirect(IApiHost src)
        {
            var methods = DirectMethods(src);
            var count = methods.Length;
            var buffer = alloc<ApiMember>(count);
            ref var dst = ref first(buffer);

            for(var i=0; i<count; i++)
            {
                var m = methods[i];
                var kid = m.Method.KindId();
                var id = Diviner.Identify(m.Method);
                var uri = ApiIdentity.uri(ApiUriScheme.Located, src.Uri, m.Method.Name, id);
                var location = address(Jit(m.Method));
                seek(dst,i) = new ApiMember(uri, m.Method, kid, location);

            }
            return buffer;
        }

        [Op]
        ApiMember[] JitGeneric(IApiHost src)
        {
            var generic = @readonly(GenericMethods(src));
            var gCount = generic.Length;
            var buffer = root.list<ApiMember>();
            for(var i=0; i<gCount; i++)
                buffer.AddRange(JitGeneric(skip(generic,i)));
            return buffer.ToArray();
        }

        /// <summary>
        /// Computes a method's numeric closures, predicated on available metadata
        /// </summary>
        /// <param name="m">The source method</param>
        [Op]
        public static NumericKind[] NumericClosureKinds(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => sys.empty<NumericKind>());

        [Op]
        static Type[] NumericClosureTypes(MethodInfo m)
            => from c in NumericClosureKinds(m)
               let t = c.ToSystemType()
               where t != typeof(void)
               select t;

        [Op]
        ApiMember[] JitGeneric(JittedMethod src)
        {
            var method = src.Method;
            var types = @readonly(NumericClosureTypes(method));
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
                    var uri = ApiIdentity.uri(ApiUriScheme.Located, src.Host, method.Name, id);
                    seek(dst,i) = new ApiMember(uri, reified, @class, address);
                }
            }
            catch(ArgumentException e)
            {
                var msg = string.Format("{0}: Closure creation failed for {1}/{2}", e.GetType().Name, method.DeclaringType.DisplayName(), method.DisplayName());
                Wf.Warn(msg);
                return sys.empty<ApiMember>();
            }
            catch(Exception e)
            {
                Wf.Warn(e.ToString());
            }
            return buffer;
        }

        public IDictionary<MethodInfo,Type> ClosureProviders(IEnumerable<Type> src)
        {
            var query = from t in src
                        from m in t.DeclaredStaticMethods()
                        let tag = m.Tag<ClosureProviderAttribute>()
                        where tag.IsSome()
                        select (m, tag.Value.ProviderType);
            return query.ToDictionary();
        }

        [Op]
        static JittedMethod[] GenericMethods(IApiHost host)
            => host.HostType.DeclaredMethods().OpenGeneric(1).Where(IsGeneric).Select(m => new JittedMethod(host.Uri, m));

        [Op]
        static bool IsGeneric(MethodInfo src)
            => src.Tagged<OpAttribute>() && src.Tagged<ClosuresAttribute>() && !src.AcceptsImmediate();

        [Op]
        static JittedMethod[] DirectMethods(IApiHost host)
            => host.HostType.DeclaredMethods().NonGeneric().Where(IsDirect).Select(m => new JittedMethod(host.Uri, m));

        [Op]
        static bool IsDirect(MethodInfo src)
            => src.Tagged<OpAttribute>() && !src.AcceptsImmediate();

        static HashSet<string> Ignore
            => root.hashset("ToString","GetHashCode", "Equals", "ToString");

    }

    partial struct Msg
    {
        public static RenderPattern<int> JittingParts => "Jitting {0} parts";

        public static RenderPattern<PartId> JittingPart => "Jitting {0} members";

        public static RenderPattern<int,PartId> JittedPart => "Jitted {0} {1} members";

        public static RenderPattern<dynamic,dynamic> JittedParts => "Jitted {0} members from {1} parts";
    }
}