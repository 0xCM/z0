//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct Cmd
    {
        [Op, Closures(UInt64k)]
        public static CmdSpec untype<T>(in T spec)
            where T : struct
        {
            var t = typeof(T);
            var fields = ClrQuery.fields(t);
            var count = fields.Length;
            var reflected = alloc<FieldValue>(count);
            Records.values(spec, fields, reflected);
            var buffer = alloc<CmdArg>(count);
            var target = span(buffer);
            var source = @readonly(reflected);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(source,i);
                seek(target,i) = new CmdArg(fv.Field.Name, fv.Value?.ToString() ?? EmptyString);
            }
            return new CmdSpec(Cmd.id(t), buffer);
        }

        /// <summary>
        /// Populates a <see cref='CmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg untype<T>(in CmdArg<T> src)
        {
            var dst = new CmdArg();
            untype(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind type</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static CmdArg untype<K,T>(in CmdArg<K,T> src)
            where K : unmanaged
        {
            var dst = new CmdArg();
            untype(src,ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref CmdArg untype<T>(in CmdArg<T> src, ref CmdArg dst)
        {
            dst = new CmdArg(src.Name, src.Value.ToString());
            return ref dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="K">The option kind type</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static ref CmdArg untype<K,T>(in CmdArg<K,T> src, ref CmdArg dst)
            where K : unmanaged
        {
            dst = new CmdArg(src.Key.ToString(), src.Value.ToString());
            return ref dst;
        }
    }
}