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
        /// Loads an assembly from a potential part path
        /// </summary>
        [Op]
        public static Option<Assembly> component(FS.FilePath src)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        [Op]
        public static Assembly[] components(FS.FilePath[] src)
            => src.Map(component).Where(x => x.IsSome()).Select(x => x.Value).Where(nonempty);

        [Op]
        static bool nonempty(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;
    }
}