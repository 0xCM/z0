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

    partial struct ApiIdentify
    {
        /// <summary>
        /// Identifies a type
        /// </summary>
        /// <param name="src">The type to identify</param>
        [Op]
        public static TypeIdentity identify(Type src)
        {
            var component = src.Assembly;
            var id = text.format(RP.SlotDot3,
                "type",
                CliArtifactKey.from(component),
                CliArtifactKey.from(src)
                );
            return TypeIdentity.define(id);
        }

        /// <summary>
        /// Identifies a method
        /// </summary>
        /// <param name="src">The method to identify</param>
        [Op]
        public static OpIdentity identify(MethodInfo src)
        {
            var type = src.DeclaringType;
            var component = type.Assembly;
            var id = text.format(RP.SlotDot4,
                "method",
                CliArtifactKey.from(component),
                CliArtifactKey.from(type),
                CliArtifactKey.from(src)
                );

            return OpIdentity.define(id);
        }

        /// <summary>
        /// Identifies a delegate
        /// </summary>
        /// <param name="src">The method to identify</param>
        [Op]
        public static OpIdentity identify(Delegate src)
        {
            var method =src.Method;
            var type = method.DeclaringType;
            var component = type.Assembly;
            var id = text.format(RP.SlotDot5,
                "delegate",
                CliArtifactKey.from(component),
                CliArtifactKey.from(type),
                CliArtifactKey.from(method),
                src.GetHashCode()
                );
            return OpIdentity.define(id);
        }
    }
}