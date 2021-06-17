//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Resources
    {
        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        [Op]
        public static Index<ApiResAccessor> bytespans(Type src)
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(ByteSpanAcessorType)
                  .Select(p => p.GetGetMethod(true))
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ApiResAccessor(src.ApiHostUri(), x, ApiAccessorKind(x.ReturnType)));

        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        [Op]
        public static Index<ApiResAccessor> charspans(Type src)
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(CharSpanAcessorType)
                  .Select(p => p.GetGetMethod(true))
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ApiResAccessor(src.ApiHostUri(), x, ApiAccessorKind(x.ReturnType)));
    }
}