//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Presents a <see cref='byte'/> reference as a <see cref='bit'/> reference
        /// </summary>
        /// <param name="src">The source byte</param>
        [MethodImpl(Inline), Op]
        public static ref bit u1(in byte src)
            => ref @as<byte,bit>(src);
    }
}