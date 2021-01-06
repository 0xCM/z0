//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial class ClrQuery
    {
        public static CliSig ResolveSignature(this MethodInfo src)
        {
            try
            {
                var token = src.MetadataToken;
                return src.Module.ResolveSignature(token);
            }
            catch
            {
                return CliSig.Empty;
            }
        }
    }
}