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

        public ApiMembers Locate(IApiHost src)
                => locate(src);

        public static IEnumerable<ApiMember> HostedDirect(IApiHost src)
                => from m in Reflex.DirectApiMethods(src)
                let id = Diviner.Identify(m)
                let uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id)
                let located = FunctionDynamic.jit(m)
                select new ApiMember(uri, located,  m.KindId());


        public static IEnumerable<ApiMember> HostedGeneric(IApiHost src)
                => from m in Reflex.GenericApiMethods(src)
                from closure in Reflex.NumericClosureTypes(m)
                let reified = m.MakeGenericMethod(closure)
                let id = Diviner.Identify(reified)
                let uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id)
                let located = FunctionDynamic.jit(m)
                select new ApiMember(uri, located, m.KindId());

        static IMultiDiviner Diviner
                => MultiDiviner.Service;
      }
}