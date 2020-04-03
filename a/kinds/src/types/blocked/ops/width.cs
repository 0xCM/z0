//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class BlockedType
    {
        public static TypeWidth width(Type src)
            => tag(src)?.TotalWdth ?? TypeWidth.None;


        static BlockedAttribute tag(Type t)
            => (BlockedAttribute)t.EffectiveType().GetCustomAttribute(typeof(BlockedAttribute));        
    }
}