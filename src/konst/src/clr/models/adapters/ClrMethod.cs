//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiType(ApiNames.ClrMethod, true)]
    public readonly struct ClrMethod : IClrRuntimeMember<ClrMethod,MethodInfo>
    {
        [MethodImpl(Inline)]
        public static ClrMethod from(MethodInfo src)
            => new ClrMethod(src);

        public MethodInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrMethod(MethodInfo src)
            => Definition = src;

        public CliKey Token
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrMemberName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
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

        public CallingConventions CallingConvention
        {
            [MethodImpl(Inline)]
            get => Definition.CallingConvention;
        }


        [MethodImpl(Inline)]
        public string Format()
            => Definition.Name;

        [Ignore]
        MethodInfo IClrRuntimeObject<MethodInfo>.Definition
            => Definition;

        [Ignore]
        ClrArtifactKind IClrRuntimeObject.ClrKind
            => ClrArtifactKind.Method;

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();

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
    }
}