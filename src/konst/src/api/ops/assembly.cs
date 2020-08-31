//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        public static Option<Assembly> assembly(FS.FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                term.error($"An attempt to load the file {src} resulted in abject failure: {e}", caller, file, line);
                return default;
            }
        }

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        internal static Option<Assembly> assembly(FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                term.error($"An attempt to load the file {src} resulted in abject failure: {e}", caller, file, line);
                return default;
            }
        }
    }
}