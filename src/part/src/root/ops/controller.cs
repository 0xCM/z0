// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct root
    {
        [MethodImpl(Inline), Op]
        public static Assembly controller()
            => Assembly.GetEntryAssembly();
    }
}