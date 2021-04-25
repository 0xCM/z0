//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class ApiQuery
    {
        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        public static IApiHost apihost(PartId part, Type type)
        {
            var name = hostname(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, name, part, new ApiHostUri(part, name), declared, index(declared));
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="type">The reifying type</param>
        [Op]
        public static IApiHost apihost(Type type)
            => apihost(type.Assembly.Id(), type);
    }
}