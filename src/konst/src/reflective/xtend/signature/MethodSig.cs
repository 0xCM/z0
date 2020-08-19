//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Identifies and describes a method that, whithin some useful scope, is unique
    /// </summary>
    public struct MethodSig
    {
        public ArtifactIdentity MethodId;

        public string MethodName;

        public Name DefiningAssembly;

        public Name DefiningModule;

        public TypeSig DeclaringType;

        public TypeSig ReturnType;

        public MethodParameters ValueParams;

        public TypeParameters TypeParams;

        public static MethodSig from(MethodInfo method)
            => new MethodSig(
                MethodId: method.MetadataToken,
                DefiningAssembly: method.Module.Assembly.GetSimpleName(),
                DefiningModule: method.Module.Name,
                DeclaringType: TypeSig.from(method.DeclaringType),
                MethodName: method.DisplayName(),
                ReturnType: TypeSig.from(method.ReturnType),
                Args: method.GetParameters().Select(p => new MethodParameter(TypeSig.from(p), p.RefKind(), p.Name, (ushort)p.Position)),
                TypeParams: TypeParameters(method));

        internal MethodSig(
            int MethodId,
            string DefiningAssembly,
            string DefiningModule,
            TypeSig DeclaringType,
            string MethodName,
            TypeSig ReturnType,
            MethodParameters Args,
            TypeParameters TypeParams
            )
        {
            this.MethodId = MethodId;
            this.DefiningAssembly = DefiningAssembly;
            this.DefiningModule = DefiningModule;
            this.DeclaringType = DeclaringType;
            this.MethodName = MethodName;
            this.ReturnType = ReturnType;
            this.ValueParams = Args;
            this.TypeParams = TypeParams;
        }

        public string Format()
        {
            var dst = text.build();
            dst.Append(ReturnType.Format());
            dst.Append(Chars.Space);
            dst.Append(MethodName);
            dst.Append(ValueParams.Format());
            return dst.ToString();
        }

        public override string ToString()
            => Format();

        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        static TypeParameter[] TypeParameters(MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => new TypeParameter(t.DisplayName(), i));
    }
}