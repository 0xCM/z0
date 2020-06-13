//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    partial class AsciCodes
    {        
        /// <summary>
        /// Creates an asci resource
        /// </summary>
        /// <param name="name">The resource name</param>
        /// <param name="content">The resource data</param>
        /// <param name="description">The resource description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        public static AsciResource<A> resource<A>(string name, A content, string description = text.Empty)
            where A : IAsciSequence
                => new AsciResource<A>(name, content, description);

        /// <summary>
        /// Creates an eponymous asci resource
        /// </summary>
        /// <param name="content">The resource data</param>
        /// <param name="description">The resource description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        public static AsciResource<A> resource<A>(A content, string description = text.Empty)
            where A : IAsciSequence
                => new AsciResource<A>(content.Text, content, description);
    }
}