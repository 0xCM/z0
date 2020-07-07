//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    [ApiHost]
    public partial class Memories
    {
        public Memories()
        {
            
        }
    }

    public static partial class XTend
    {
        /// <summary>
        /// Convers a source value, which is hopefully a supported kind, to a target kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static object To(this NumericKind dst, object src)
            => Cast.to(src,dst);                    
    }
}