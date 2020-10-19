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
        /// Determines whether a property is an indexer
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool IsIndexer(this PropertyInfo p)
            => p.GetIndexParameters().Length > 0;
    }
}