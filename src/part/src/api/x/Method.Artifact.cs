//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial class XApi
    {
        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [Op]
        public static ClrMethodArtifact Artifact(this MethodInfo src)
            => metadata(src);

        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [Op]
        static ClrMethodArtifact metadata(MethodInfo src)
        {
            var dst = new ClrMethodArtifact();
            dst.Id = src.MetadataToken;
            dst.MethodName = src.DisplayName();
            dst.DefiningAssembly = src.Module.Assembly;
            dst.DefiningModule = src.Module.Name;
            dst.DeclaringType = src.DeclaringType.SigInfo();
            dst.ReturnType = src.ReturnType.SigInfo();
            dst.Args = src.GetParameters().Select(p => new ClrParamInfo(p.SigInfo(), p.RefKind(), p.Name, (ushort)p.Position));
            dst.TypeParameters = src.GenericParameters(false).Mapi((i,t) => t.DisplayName());
            return dst;
        }
    }
}