//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct Resources
    {
        /// <summary>
        /// Queries the source assemblies for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Assembly[] src)
            => accessors(src.SelectMany(x => x.GetTypes()));

        /// <summary>
        /// Queries the source assembly for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assembly to query</param>
        [MethodImpl(Inline), Op]
        public static Index<ApiResAccessor> accessors(Assembly src)
            => accessors(src.GetTypes());

        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Type[] src)
            => src.Where(t => !t.IsInterface).SelectMany(x => accessors(x));

        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Index<Type> src)
            => src.Where(t => !t.IsInterface).SelectMany(accessors).Array();

        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Type src)
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(ResAccessorTypes)
                  .Select(p => p.GetGetMethod(true))
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ApiResAccessor(src.ApiHostUri(), x, ApiAccessorKind(x.ReturnType)));

        static Type[] ResAccessorTypes
            => new Type[]{ByteSpanAcessorType, CharSpanAcessorType};

        static Type ByteSpanAcessorType
            => typeof(ReadOnlySpan<byte>);

        static Type CharSpanAcessorType
            => typeof(ReadOnlySpan<char>);

        [Op]
        static ApiResKind ApiAccessorKind(Type match)
        {
            ref readonly var src = ref first(span(ResAccessorTypes));
            var kind = ApiResKind.None;
            if(skip(src,0).Equals(match))
                kind = ApiResKind.ByteSpan;
            else if(skip(src,1).Equals(match))
                kind = ApiResKind.CharSpan;
            return kind;
        }
    }
}