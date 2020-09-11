// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using static Konst;

    public readonly struct ArtifactIdentities : IMultiDiviner
    {
        public TypeIdentity DivineIdentity(Type type)
        {
            var component = type.Assembly;
            var id = text.format(RenderPatterns.SlotDot3,
                "type",
                ArtifactIdentifier.from(component),
                ArtifactIdentifier.from(type)
                );
            return TypeIdentity.define(id);
        }

        public OpIdentity DivineIdentity(MethodInfo method)
        {
            var type = method.DeclaringType;
            var component = type.Assembly;
            var id = text.format(RenderPatterns.SlotDot4,
                "method",
                ArtifactIdentifier.from(component),
                ArtifactIdentifier.from(type),
                ArtifactIdentifier.from(method)
                );

            return OpIdentity.define(id);
        }

        public OpIdentity DivineIdentity(Delegate src)
        {
            var method =src.Method;
            var type = method.DeclaringType;
            var component = type.Assembly;
            var id = text.format(RenderPatterns.SlotDot5,
                "delegate",
                ArtifactIdentifier.from(component),
                ArtifactIdentifier.from(type),
                ArtifactIdentifier.from(method),
                src.GetHashCode()
                );
            return OpIdentity.define(id);
        }

        public GenericOpIdentity GenericIdentity(MethodInfo src)
            => GenericOpIdentity.Define(DivineIdentity(src));

    }
}