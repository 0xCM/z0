//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;
    using static CmdVarTypes;

    using Types = CmdVarTypes;

    [ApiHost]
    public readonly partial struct CmdVars
    {
        const NumericKind Closure = UnsignedInts;

        const BindingFlags MemberSelector = BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly;

        internal const byte MaxVarCount = 16;

        [MethodImpl(Inline), Op]
        public static CmdVarSymbol symbol(string name)
            => new CmdVarSymbol(name);

        public static Index<ICmdVar> members<T>(T set)
            where T : ICmdVars<T>, new()
                => typeof(T).GetProperties(MemberSelector).Select(x => (ICmdVar)x.GetValue(set));

        /// <summary>
        /// Creates a non-valued <see cref='DirVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        [MethodImpl(Inline), Op]
        public static DirVar dir(CmdVarSymbol symbol)
            => new DirVar(symbol);

        /// <summary>
        /// Creates a valued <see cref='DirVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        /// <param name="value">The variable value</param>
        [MethodImpl(Inline), Op]
        public static DirVar dir(CmdVarSymbol symbol, FS.FolderPath value)
            => new DirVar(symbol, value);

        /// <summary>
        /// Creates a non-valued <see cref='CmdScriptVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        [MethodImpl(Inline), Op]
        public static CmdScriptVar var(CmdVarSymbol symbol)
            => new CmdScriptVar(symbol);

        /// <summary>
        /// Creates a valued <see cref='CmdScriptVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        /// <param name="value">The variable value</param>
        [MethodImpl(Inline), Op]
        public static CmdScriptVar var(CmdVarSymbol symbol, CmdVarValue value)
            => new CmdScriptVar(symbol, value);

        [MethodImpl(Inline), Op]
        public static CmdVarSymbol combine(CmdVarSymbol a, CmdVarSymbol b)
            => new CmdVarSymbol(string.Format("{0}{1}", a, b));

        [MethodImpl(Inline), Op]
        public static CmdVarSymbol combine<T>(CmdVarSymbol<T> a, CmdVarSymbol<T> b)
            => new CmdVarSymbol(string.Format("{0}{1}", a,b));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> define<K>(K id, in Cell128 value)
            where K : unmanaged
                => new CmdVar<K>(id, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> define<K>(K id, string value)
            where K : unmanaged
                => new CmdVar<K>(id, value);
        [Op]
        public static CmdVarIndex init(byte count)
            => new CmdVarIndex(new CmdVar[count]);

        [Op]
        public static CmdVarIndex init()
            => new CmdVarIndex(new CmdVar[MaxVarCount]);

        [Op, Closures(Closure)]
        public static CmdVarIndex<K> init<K>()
            where K : unmanaged
                => new CmdVarIndex<K>(new CmdVar<K>[MaxVarCount]);
        [Op]
        public static Types.EnvVars env()
        {
            var dst = new CmdVarTypes.EnvVars();
            dst.DevRoot = (nameof(dst.DevRoot), FS.dir(Environment.GetEnvironmentVariable("ZDev")));
            dst.Db = (nameof(dst.Db), FS.dir(Environment.GetEnvironmentVariable("ZDb")));
            dst.Control = (nameof(dst.Control), FS.dir(Environment.GetEnvironmentVariable("ZControl")));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static CmdScriptVar set(CmdScriptVar src, string value)
            => var(src.Symbol, value);

        [MethodImpl(Inline), Op]
        public static DirVar set(DirVar src, FS.FolderPath value)
            => dir(src.Symbol, value);

        [Op]
        public static void render(DirVars src, ITextBuffer dst)
        {
            var members = src.Members().View;
            var count = members.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(format(skip(members,i)));
        }

        [Op, Closures(Closure)]
        public static string format<T>(CmdVarSymbol<T> src)
            => string.Format("{0}", src.Name);

        [Op]
        public static string format(CmdVarValue src)
            => src.Content ?? EmptyString;

        [Op]
        public static string format(ICmdVar src)
            => string.Format("{0}={1}", src.Symbol, src.Value);

        [Op]
        public static string format(CmdVarSymbol src)
            => string.Format("$({0})",src.Name ?? EmptyString);

        [Op]
        public static string format(ICmdVars src)
        {
            var dst = text.build();
            foreach(var member in src.Members())
                dst.AppendLine(format(member));
            return dst.ToString();
        }

    }
}