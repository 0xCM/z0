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

      using static Konst;

      public readonly struct MemberLocator : IApiMemberLocator
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

        static IEnumerable<ApiMember> HostedDirect(IApiHost src)
            => from m in ApiQuery.DirectApiMethods(src)
                let id = MultiDiviner.Service.Identify(m)
                let im = new IdentifiedMethod(id,m)
                let uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id)
                let located = ApiDynamic.jit(im)
                select new ApiMember(uri, located,  m.KindId());

        static IEnumerable<ApiMember> HostedGeneric(IApiHost src)
                => from m in ApiQuery.GenericApiMethods(src)
                from closure in ApiQuery.NumericClosureTypes(m)
                let reified = m.MakeGenericMethod(closure)
                let id = MultiDiviner.Service.Identify(reified)
                let im = new IdentifiedMethod(id,m)
                let uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id)
                let located = ApiDynamic.jit(im)
                select new ApiMember(uri, located, m.KindId());
      }
}