//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(Type src)
            => src.TypeHandle.Value;

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(MethodInfo src)
            => src.MethodHandle.Value;

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(FieldInfo src)
            => src.FieldHandle.Value;

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(Delegate src)
            => src.Method.MethodHandle.Value;
    }
}