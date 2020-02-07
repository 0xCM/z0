//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.ComponentModel;
    using System.Collections.Concurrent;

    using static RootShare;
 
    partial class RootReflections
    {

        /// <summary>
        /// Raises an error if a method is nongeneric
        /// </summary>
        /// <param name="src">the source method</param>
        public static void RequireGeneric(this MethodInfo src)        
        {
            if (src.IsNonGeneric())
                throw src.RequireGenericError();
        }

        /// <summary>
        /// Populates an exception with a message, but does not verify that the constraint has actually failed
        /// </summary>
        /// <param name="src">The source method</param>
        public static Exception RequireGenericError(this MethodInfo src)
            => new Exception($"The method {src} is nongenric");
    }

}