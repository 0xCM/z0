//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    partial class Api
    {
        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> HostTypes(Assembly src)
            => src.GetTypes().Tagged<ApiHostAttribute>();

        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<ApiHost> Hosts(Assembly src)
            => HostTypes(src).Select(Host);

        [MethodImpl(Inline)]
        public static ApiHost Host(Type src)
        {
            var owner = src.Assembly.Id();            
            return  ApiHost.Define(owner, src);
        }

        [MethodImpl(Inline)]
        public static OpUri MemberUri(ApiLocatedMember src)        
            => OpUri.Define(OpUriScheme.Located, src.HostUri, src.Method.Name, src.Id);

        [MethodImpl(Inline)]
        public static OpUri MemberUri(ApiStatelessMember src)        
            => OpUri.Define(OpUriScheme.Type, src.HostUri, src.Method.Name, src.Id);

        [MethodImpl(Inline)]
        public static OpUri MemberUri(ApiServiceMember src)        
            => OpUri.Define(OpUriScheme.Svc, src.HostUri, src.Method.Name, src.Id);
    }

}