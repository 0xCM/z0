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

    using static Konst;
    using static z;

    partial struct Resources
    {

        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        public static ResourceAccessor[] accessors(Type src)        
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(AccessorTypes)
                  .Select(p => p.GetGetMethod(true))                  
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ResourceAccessor(x, FormatType(x.ReturnType)));
     
        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        public static ResourceAccessors accessors(IEnumerable<Type> src)        
            => src.Where(t => !t.IsInterface).SelectMany(accessors).ToArray();
        
        /// <summary>
        /// Queries the source assembly for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assembly to query</param>
        public static ResourceAccessors accessors(Assembly src)        
            => accessors(src.GetTypes());
    
        /// <summary>
        /// Queries the source assemblies for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        public static ResourceAccessors accessors(IEnumerable<Assembly> src)
            => accessors(src.SelectMany(x => x.GetTypes()));
            
        static Type[] AccessorTypes => new Type[]{
            typeof(ReadOnlySpan<byte>), 
            typeof(ReadOnlySpan<char>), 
            };

        static ResourceFormat FormatType(Type match)
        {
            ref readonly var src = ref first(span(AccessorTypes));
            var kind = ResourceFormat.None;
            if(skip(src,0).Equals(match))
                kind = ResourceFormat.ByteSpan;
            else if(skip(src,1).Equals(match))
                kind = ResourceFormat.CharSpan;
            return kind;
        }
    }
}