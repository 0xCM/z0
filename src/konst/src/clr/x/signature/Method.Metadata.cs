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
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [Op]
        public static MethodMetadata Metadata(this MethodInfo src)
        {
            var dst = new MethodMetadata();
            dst.MethodId = src.MetadataToken;
            dst.DefiningAssembly = src.Module.Assembly.GetSimpleName();
            dst.DefiningModule = src.Module.Name;
            dst.DeclaringType = TypeSigInfo.from(src.DeclaringType);
            dst.ReturnType = TypeSigInfo.from(src.ReturnType);
            dst.ValueParams = src.GetParameters().Select(p => new MethodParameter(TypeSigInfo.from(p), p.RefKind(), p.Name, (ushort)p.Position));
            dst.TypeParams = src.TypeParameters();
            return dst;

            // return new MethodMetadata(
            //     id: src.MetadataToken,
            //     assembly: src.Module.Assembly.GetSimpleName(),
            //     module: src.Module.Name,
            //     type: TypeSigInfo.from(src.DeclaringType),
            //     name: src.DisplayName(),
            //     tReturn: TypeSigInfo.from(src.ReturnType),
            //     args: src.GetParameters().Select(p => new MethodParameter(TypeSigInfo.from(p), p.RefKind(), p.Name, (ushort)p.Position)),
            //     tParams: src.TypeParameters());
        }

    }
}