//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static memory;
    using static corefunc;

    public readonly struct CliSigs
    {
        /// <summary>
        /// Determines the <see cref='CliSig'/> for a specified <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline), Op]
        public static CliSig resolve(MethodInfo src)
        {
            TryResolve(src, out var dst);
            return dst;
        }

        static bool TryResolve(MethodInfo src, out CliSig dst)
        {
            try
            {
                dst = src.Module.ResolveSignature(src.MetadataToken);
                return true;
            }
            catch
            {
                dst = CliSig.Empty;
                return false;
            }
        }

        public static Index<CliSig> resolve(MethodInfo[] src)
        {
            var count = corefunc.count(src);
            if(count==0)
                return default;

            var dst = sys.alloc<CliSig>(count);
            sigs(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void sigs(MethodInfo[] src, Span<CliSig> dst)
        {
            var k = min(count(src), count(dst));
            if(k != 0)
            {
                ref readonly var input = ref first(src);
                ref var output = ref first(dst);
                for(var i=0; i<k; i++)
                    seek(output,i) = resolve(skip(input,i));
            }
        }

        /// <summary>
        /// Determines the <see cref='CliSig'/> for a specified <see cref='Type'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static Outcome<CliSig> resolve(Type src)
        {
            var module = src.Module;
            try
            {
                return new CliSig(module.ResolveSignature(src.MetadataToken));
            }
            catch(Exception)
            {
                var msg = $"Signature resolution failure: The signature of the type {src.AssemblyQualifiedName} was not found in the module {src.Module}";

                throw new AppException(AppMsg.error(msg));
            }
        }

        /// <summary>
        /// Determines the <see cref='CliSig'/> for a specified <see cref='FieldInfo'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static CliSig resolve(FieldInfo src)
            => new CliSig(src.Module.ResolveSignature(src.MetadataToken));
    }
}