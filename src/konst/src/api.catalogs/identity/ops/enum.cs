//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Defines an <see cref='Enum'/> identifier
        /// </summary>
        [MethodImpl(Inline), Op]
        public static EnumIdentity @enum(Type src)
            => EnumIdentity.Define(src);
    }
}