//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        /// <summary>
        /// Reimagines a boolean value as a character value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static char @char(bool src)
            => (char)(u8(src) + 48);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref char @char<E>(in E src) 
            where E : unmanaged
                => ref @as<E,char>(src);
    }
}