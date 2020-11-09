//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines the primary interface for clr artifact interrogation
    /// </summary>
    [ApiHost(ApiNames.ClrArtifacts, true)]
    public readonly partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static ClrTypeCodes TypeCodes()
            => ClrTypeCodes.cached();

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(FieldInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(PropertyInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(MethodInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(EventInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrTypeName name(Type src)
            => new ClrTypeName(src.AssemblyQualifiedName);
    }
}