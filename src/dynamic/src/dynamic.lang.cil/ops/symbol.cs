//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;

    partial struct CilApi
    {
        [MethodImpl(Inline), Op]
        public static CilOpCodeSymbol symbol(ILOpCode id)
            => new CilOpCodeSymbol(id);

        [MethodImpl(Inline)]
        public static CilOpCodeSymbol symbol<K>(K k = default)
            where K : unmanaged, ICilOpCode<K>
                => new CilOpCodeSymbol((ILOpCode)(default(K).Id));
    }
}