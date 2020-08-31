//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;
    
    public readonly struct FormatFx
    {
        /// <summary>
        /// Characterizes a content render function
        /// </summary>
        /// <param name="src">The content value</param>
        /// <typeparam name="T">The content type</typeparam>
        public delegate string Format<T>(T src);

        /// <summary>
        /// Characterizes a title render function
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The type for which titles will be provided</typeparam>
        public delegate string FormatTitle<T>(T src);        
    }
}