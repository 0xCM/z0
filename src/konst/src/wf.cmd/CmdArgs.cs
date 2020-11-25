//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct CmdArgs
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static string name<K,T>(in CmdArg<K,T> src)
            where K : unmanaged
                => src.Key.ToString();

         public static CmdArgIndex index<T>(T src)
            where T : struct, ICmdSpec<T>
                => typeof(T).DeclaredInstanceFields().Select(f => new CmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));

        /// <summary>
        /// Creates a <see cref='CmdArgIndex'/> collection from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static CmdArgIndex index(params CmdArg[] src)
            => new CmdArgIndex(src);

        /// <summary>
        /// Defines a <see cref='CmdArg'/>
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="value">The option value</param>
        [MethodImpl(Inline), Op]
        public static CmdArg arg(string name, string value)
            => new CmdArg(name, value);

        [Op]
        public static CmdArg arg(string name, string[] values)
            => new CmdArg(name, values.Concat(';'));

        /// <summary>
        /// Defines a <see cref='CmdArg{T}'/>
        /// </summary>
        /// <param name="name">The option identifier</param>
        /// <param name="value">The option value</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(string name, T value)
            => new CmdArg<T>(name, value);

        /// <summary>
        /// Defines a <see cref='CmdArg{K,T}'/>
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="value"></param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static CmdArg<K,T> arg<K,T>(K kind, T value)
            where K : unmanaged
                => new CmdArg<K,T>(kind,value);

        /// <summary>
        /// Populates a <see cref='CmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref CmdArg data<T>(in CmdArg<T> src, ref CmdArg dst)
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
        public static ref CmdArg data<K,T>(in CmdArg<K,T> src, ref CmdArg dst)
            where K : unmanaged
        {
            dst = new CmdArg(src.Key.ToString(), src.Value.ToString());
            return ref dst;
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
            data(src,ref dst);
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
            data(src,ref dst);
            return dst;
        }

        [Op, Closures(UInt64k)]
        public static CmdSpec untype<T>(in T spec)
            where T : struct
        {
            var t = typeof(T);
            var fields = ClrQuery.fields(t);
            var count = fields.Length;
            var reflected = alloc<ClrFieldValue>(count);
            ClrQuery.values(spec, fields, reflected);
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

        [Op]
        public static void render(CmdArgIndex src, ITextBuffer dst)
        {
            var count = src.Count;
            for(var i=0u; i<count; i++)
            {
                dst.Append(format(src[i]));
                if(i != count - 1)
                    dst.Append(Space);
            }
        }

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static string format(in CmdArg src)
            => Render.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in CmdArg<T> src)
            => Render.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<K,T>(in CmdArg<K,T> src)
            where K : unmanaged
                => Render.setting(src.Key, src.Value);
    }
}
