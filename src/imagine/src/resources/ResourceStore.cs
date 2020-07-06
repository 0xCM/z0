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
    using static Root;
    
    public readonly struct ResourceStore
    {                
        public static ResourceStore Service => default;        

        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        public ResourceAccessor[] Accessors(Type src)        
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
        public ResourceAccessors Accessors(IEnumerable<Type> src)        
            => src.Where(t => !t.IsInterface).SelectMany(Accessors).ToArray();
        
        /// <summary>
        /// Queries the source assembly for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assembly to query</param>
        public ResourceAccessors Accessors(Assembly src)        
            => Accessors(src.GetTypes());

        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        public ResourceDeclarations[] Declarations(Assembly src)    
            => (from a in Accessors(src).Accessors 
                let t = a.Member.DeclaringType
                group a by t).Map(x => new ResourceDeclarations(x.Key, x.ToArray()));
    
        /// <summary>
        /// Queries the source assemblies for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        public ResourceAccessors Accessors(IEnumerable<Assembly> src)
            => Accessors(src.SelectMany(x => x.GetTypes()));
            
        static Type[] AccessorTypes => new Type[]{
            typeof(ReadOnlySpan<byte>), 
            typeof(ReadOnlySpan<char>), 
            };

        static ResourceFormat FormatType(Type match)
        {
            ref readonly var src = ref head(span(AccessorTypes));
            var kind = ResourceFormat.None;
            if(Root.skip(src,0).Equals(match))
                kind = ResourceFormat.ByteSpan;
            else if(Root.skip(src,1).Equals(match))
                kind = ResourceFormat.CharSpan;
            return kind;
        }
    }
}