// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct root
    {
        /// <summary>
        /// Right now
        /// </summary>
        [MethodImpl(Inline), Op]
        public static DateTime now()
            => DateTime.Now;
    }
}