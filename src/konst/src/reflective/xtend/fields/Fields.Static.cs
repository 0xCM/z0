//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Selects the static fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Static(this FieldInfo[] src)
            => src.Where(x => x.IsStatic);

        /// <summary>
        /// Selects the instance fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Instance(this FieldInfo[] src)
            => src.Where(x => !x.IsStatic);
    }
}