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

      public readonly struct MemberLocator : IMemberLocator
      {
        public static MemberLocator Service
                => default;

        public static ApiMembers locate(IApiHost src)
        {
            var generic = HostedGeneric(src);
            var direct = HostedDirect(src);
            var all = direct.Concat(generic).Array();
            return all.OrderBy(x => x.Method.MetadataToken);
        }

        public static Type[] numeric(MethodInfo m)
            => from c in ClosureKinds.numeric(m)
               let t = c.SystemType()
               where t != typeof(void)
               select t;

        public ApiMembers Locate(IApiHost src)
                => locate(src);

        public static IEnumerable<ApiMember> HostedDirect(IApiHost src)
                => from m in DirectMethods(src)
                let id = Diviner.Identify(m)
                let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                let located = FunctionDynamic.jit(m)
                select new ApiMember(uri, located,  m.KindId());


        public static IEnumerable<ApiMember> HostedGeneric(IApiHost src)
                => from m in GenericMethods(src)
                from closure in numeric(m)
                let reified = m.MakeGenericMethod(closure)
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(OpUriScheme.Type, src.Uri, m.Name, id)
                let located = FunctionDynamic.jit(m)
                select new ApiMember(uri, located, m.KindId());

        public static IEnumerable<MethodInfo> GenericMethods(IApiHost src)
                => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                    where m.Tagged<OpAttribute>()
                    && m.Tagged<ClosuresAttribute>()
                    && !m.AcceptsImmediate()
                    select m;

        public  static IEnumerable<MethodInfo> DirectMethods(IApiHost src)
                => from m in src.HostType.DeclaredMethods().NonGeneric()
                where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                select m;

        static IMultiDiviner Diviner
                => MultiDiviner.Service;
      }
}