//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Clr
    {
        /// <summary>
        /// Determines the <see cref='CliSig'/> for a specified <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline), Op]
        public static CliSig sig(MethodInfo src)
        {
            sig(src, out var dst);
            return dst;
        }

        public static bool sig(MethodInfo src, out CliSig dst)
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

        // [Op]
        // public static bool sig(Type src, out CliSig dst)
        // {
        //     var module = src.Module;
        //     try
        //     {
        //         dst = new CliSig(module.ResolveSignature(src.MetadataToken));
        //         return true;
        //     }
        //     catch(Exception)
        //     {
        //         dst = CliSig.Empty;
        //         return false;
        //     }
        // }
    }
}