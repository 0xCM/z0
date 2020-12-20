//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Q = ApiQuery;

    partial struct Resources
    {
        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        [Op]
        public static ApiMemberRes[] api(Type src)
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(Q.ResAccessorTypes)
                  .Select(p => p.GetGetMethod(true))
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ApiMemberRes(Q.uri(src), x, Q.FormatAccessor(x.ReturnType)));
    }
}