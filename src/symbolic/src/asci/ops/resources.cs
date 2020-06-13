//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static Control;

    partial class AsciCodes
    {
        /// <summary>
        /// Creates an asci resource sequence
        /// </summary>
        /// <param name="name">The sequence name</param>
        /// <param name="content">The resource data</param>
        /// <param name="description">The sequence description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        public static AsciResources<A> resources<A>(string name, AsciResource<A>[] content, string description = text.Empty)
            where A : IAsciSequence
                => new AsciResources<A>(name, content, description);

        /// <summary>
        /// Creates an asci resource sequence with eponymous elements
        /// </summary>
        /// <param name="name">The sequence name</param>
        /// <param name="content">The resource data</param>
        /// <param name="description">The sequence description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        public static AsciResources<A> resources<A>(string name, A[] content, string description = text.Empty)
            where A : IAsciSequence
        {
            var count = content.Length;
            var buffer = new AsciResource<A>[count];
            var dst = buffer.ToSpan();
            var src = content.ToReadOnlySpan();

            for(var i=0; i<count; i++)
                seek(dst,i) = resource(skip(src,i));

            return resources(name,buffer,description);
        }
    }
}