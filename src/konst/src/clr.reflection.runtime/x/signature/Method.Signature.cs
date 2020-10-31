//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial class XClrQuery
    {
        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        [Op]
        static TypeParameter[] TypeParameters(this MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => new TypeParameter(t.DisplayName(), i));

        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [Op]
        public static MethodMetadata Metadata(this MethodInfo src)
            => new MethodMetadata(
                MethodId: src.MetadataToken,
                DefiningAssembly: src.Module.Assembly.GetSimpleName(),
                DefiningModule: src.Module.Name,
                DeclaringType: TypeSig.from(src.DeclaringType),
                MethodName: src.DisplayName(),
                ReturnType: TypeSig.from(src.ReturnType),
                Args: src.GetParameters().Select(p => new MethodParameter(TypeSig.from(p), p.RefKind(), p.Name, (ushort)p.Position)),
                TypeParams: src.TypeParameters());
    }
}