//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Option<IPart> part(Assembly src)
        {
            try
            {
                return some(src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).FirstOrDefault());
            }
            catch(Exception e)
            {
                term.error(AppErrors.define(nameof(ApiQuery), text.format("Assembly {0} | {1}", src.GetSimpleName(), e)));
                return none<IPart>();
            }
        }

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        public static Option<IPart> part(FS.FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => from c in component(src)
                from t in resolve(c)
                from p in resolve(t)
                from part in resolve(p)
                select part;
    }
}