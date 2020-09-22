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

    partial struct ApiIdentity
    {
        /// <summary>
        /// Identifies a type
        /// </summary>
        /// <param name="src">The type to identify</param>
        [Op]
        public static TypeIdentity identify(Type src)
        {
            var component = src.Assembly;
            var id = text.format(RenderPatterns.SlotDot3,
                "type",
                ApiArtifactKey.from(component),
                ApiArtifactKey.from(src)
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
            var id = text.format(RenderPatterns.SlotDot4,
                "method",
                ApiArtifactKey.from(component),
                ApiArtifactKey.from(type),
                ApiArtifactKey.from(src)
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
            var id = text.format(RenderPatterns.SlotDot5,
                "delegate",
                ApiArtifactKey.from(component),
                ApiArtifactKey.from(type),
                ApiArtifactKey.from(method),
                src.GetHashCode()
                );
            return OpIdentity.define(id);
        }
    }
}