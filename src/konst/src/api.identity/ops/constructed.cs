//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Root;

    partial struct ApiIdentity
    {
        /// <summary>
        /// Assigns host-independent api identity to a constructed generic method
        /// </summary>
        /// <param name="src">The constructed method</param>
        [Op]
        public static OpIdentity constructed(MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                root.@throw(AppErrors.NonGenericMethod(src));

            var id = EmptyString;
            id += name(src);
            id += IDI.PartSep;
            id += IDI.Generic;
            id += TypeArgIdentity(src);
            id += ValueParamIdentity(src);
            return ApiUri.opid(id);
        }
    }
}