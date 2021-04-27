//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct ClrArtifactRef : ITextual
    {
        /// <summary>
        /// Defines a reference to an artifact of parametric type
        /// </summary>
        /// <param name="src">The source artifact</param>
        /// <typeparam name="A">The artifact type</typeparam>
        [MethodImpl(Inline)]
        public static ClrArtifactRef define(CliToken id, ClrArtifactKind kind, Name name)
            => new ClrArtifactRef(id,kind,name);

        /// <summary>
        /// Defines a reference to an artifact of parametric type
        /// </summary>
        /// <param name="src">The source artifact</param>
        /// <typeparam name="A">The artifact type</typeparam>
        [MethodImpl(Inline)]
        public static ClrArtifactRef define<M>(M src)
            where M : MemberInfo
                => define(src.MetadataToken, ClrArtifactKind.Field, src.Name);

        public ClrArtifactKind Kind {get;}

        public CliToken Token {get;}

        public Name Name {get;}

        [MethodImpl(Inline)]
        public ClrArtifactRef(CliToken id, ClrArtifactKind kind, Name name)
        {
            Token = id;
            Kind = kind;
            Name = name;
        }

        public string Format()
            => string.Format(RP.PSx3, Kind, Token, Name);

        public override string ToString()
            => Format();
    }
}