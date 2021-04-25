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

    using static memory;

    partial class ApiQuery
    {
        [Op]
        public static Index<IApiHost> apihosts(Assembly src)
        {
            var _id = src.Id();
            return ApiHostTypes(src).Select(h => apihost(_id, h));
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Index<Type> ApiHostTypes(Assembly src)
            => src.GetTypes().Where(IsApiHost);

        [Op]
        static bool IsApiHost(Type src)
            => src.Tagged<ApiHostAttribute>();
    }
}