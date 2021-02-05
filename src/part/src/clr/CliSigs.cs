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
    using static memory;
    using static root;

    [ApiHost]
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
            var count = root.count(src);
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
        public static bool resolve(Type src, out CliSig dst)
        {
            var module = src.Module;
            try
            {
                dst = new CliSig(module.ResolveSignature(src.MetadataToken));
                return true;
            }
            catch(Exception)
            {
                dst = CliSig.Empty;
                return false;
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