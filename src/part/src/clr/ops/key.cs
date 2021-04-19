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
    using static ReflectionFlags;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ulong key(Assembly src)
            => (ulong)src.ManifestModule.MetadataToken;

        [MethodImpl(Inline), Op]
        public static ulong key(Type src)
        {
            var upper = (ulong)src.Assembly.ManifestModule.MetadataToken << 32;
            var lower = (ulong)src.MetadataToken;
            return upper | lower;
        }

        [MethodImpl(Inline), Op]
        public static ulong key(MethodInfo src)
        {
            var upper = (ulong)src.DeclaringType.MetadataToken << 32;
            var lower = (ulong)src.MetadataToken;
            return upper | lower;
        }

        [MethodImpl(Inline), Op]
        public static ulong key(EventInfo src)
        {
            var upper = (ulong)src.DeclaringType.MetadataToken << 32;
            var lower = (ulong)src.MetadataToken;
            return upper | lower;
        }

        [MethodImpl(Inline), Op]
        public static ulong key(FieldInfo src)
        {
            var upper = (ulong)src.DeclaringType.MetadataToken << 32;
            var lower = (ulong)src.MetadataToken;
            return upper | lower;
        }

        [MethodImpl(Inline), Op]
        public static ulong key(PropertyInfo src)
        {
            var upper = (ulong)src.DeclaringType.MetadataToken << 32;
            var lower = (ulong)src.MetadataToken;
            return upper | lower;
        }
    }
}