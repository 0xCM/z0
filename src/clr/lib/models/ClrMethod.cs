//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiDataType]
    public readonly struct ClrMethod
    {
        [MethodImpl(Inline)]
        public static ClrMethod from(MethodInfo src)
            => new ClrMethod(src);

        public MethodInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrMethod(MethodInfo src)
            => Definition = src;

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        public ClrAssembly Assembly
        {
            [MethodImpl(Inline)]
            get => DeclaringType.Assembly;
        }

        public ClrType DeclaringType
        {
            [MethodImpl(Inline)]
            get => Definition.DeclaringType;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(ClrMethod lhs, ClrMethod rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrMethod lhs, ClrMethod rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator MethodInfo(ClrMethod src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrMethod(MethodInfo src)
            => from(src);

        [MethodImpl(Inline)]
        public string Format()
            => Definition.Name;

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();
    }
}