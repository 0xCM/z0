//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using static Konst;

    public readonly struct AppResources
    {                
        public static AppResources Service => default;

        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        public IEnumerable<MethodInfo> ByteSpanAccessors(Type src)        
            => src.DeclaredStaticProperties()
                  .Where(p => p.PropertyType == typeof(ReadOnlySpan<byte>))
                  .Select(p => p.GetGetMethod())
                  .Where(m  => m != null);
     
        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        public IEnumerable<MethodInfo> ByteSpanAccessors(IEnumerable<Type> src)        
            => src.SelectMany(ByteSpanAccessors);
        
        /// <summary>
        /// Queries the source assembly for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assembly to query</param>
        public IEnumerable<MethodInfo> ByteSpanAccessors(Assembly src)        
            => ByteSpanAccessors(src.GetTypes());

        /// <summary>
        /// Queries the source assemblies for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        public IEnumerable<MethodInfo> ByteSpanAccessors(IEnumerable<Assembly> src)
            => src.SelectMany(ByteSpanAccessors);
    }
}