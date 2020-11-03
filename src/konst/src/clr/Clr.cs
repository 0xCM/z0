//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;

    using static Konst;
    using static z;

    public readonly struct Clr
    {
        [MethodImpl(Inline), Op]
        public static CliSig sig(MethodInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));

        [Op]
        public static CliSig sig(Type src)
        {
            var module = src.Module;
            try
            {
                return new CliSig(module.ResolveSignature(src.MetadataToken));
            }
            catch(Exception)
            {
                throw new AppException(AppMsg.error($"Signature resolution failure: The signature of the type {src.AssemblyQualifiedName} was not found in the module {src.Module}"));
            }
        }

        [MethodImpl(Inline), Op]
        public static CliSig sig(FieldInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));
    }
}