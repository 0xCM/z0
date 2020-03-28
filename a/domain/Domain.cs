//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Domain)]

namespace Z0.Parts
{        
    public sealed class Domain : Part<Domain> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Domain
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        

        /// <summary>
        /// Appends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        internal static string rspace(object content)
            => $"{content} ";

        /// <summary>
        /// Prepends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline)]
        internal static string lspace(object content)
            => $" {content}";


    }

    public static partial class XDomain    
    {

    }
}
