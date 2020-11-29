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

    partial struct Cmd
    {
        [Op]
        public static bool lookup(CmdArgIndex src, string name, out CmdArg dst)
        {
            for(var i=0; i<src.Count; i++)
            {
                ref readonly var arg = ref src[i];
                if(text.equals(arg.Name, name))
                {
                    dst=arg;
                    return true;
                }
            }
            dst = CmdArg.Empty;
            return false;
        }

        [MethodImpl(Inline), Factory]
        public CmdArgProtocol protocol(CmdArgPrefix prefix, AsciCharCode qualifier = AsciCharCode.Space)
            => new CmdArgProtocol(prefix, qualifier);

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
        /// Creates a <see cref='CmdArgPrefix'/>
        /// </summary>
        /// <param name="c0">The delimiter</param>
        [MethodImpl(Inline), Factory]
        public static CmdArgPrefix prefix(char c0)
            => new CmdArgPrefix((AsciCharCode)c0);

        /// <summary>
        /// Creates a <see cref='CmdArgPrefix'/>
        /// </summary>
        /// <param name="c0">The first part of the delimiter</param>
        /// <param name="c1">The second part of the delimiter</param>
        [MethodImpl(Inline), Factory]
        public static CmdArgPrefix prefix(char c0, char c1)
            => new CmdArgPrefix((AsciCharCode)c0, (AsciCharCode)c1);

        [MethodImpl(Inline), Factory]
        public static CmdArgPrefix prefix(string src)
        {
            var count = src.Length;
            if(count == 0 || count > 2)
                @throw(bad(src));
            if(count == 1)
                return prefix(src[0]);
            else
                return prefix(src[0], src[1]);
        }

    }
}