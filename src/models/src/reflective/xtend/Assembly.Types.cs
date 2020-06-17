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
        public static Type[] Types(this Assembly a)
            => a.GetTypes();

        public static Type[] PublicTypes(this Assembly a)
            => a.Types().Public();

        public static Type[] NonPublicTypes(this Assembly a)
            => a.Types().NonPublic();
    }
}