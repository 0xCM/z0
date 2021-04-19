//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;

    public struct ClrDbSnapshot
    {
        public Index<Type[]> Types;

        public Index<MethodInfo[]> Methods;

        public Index<FieldInfo[]> Fields;

        public Index<PropertyInfo[]> Properties;
    }
}