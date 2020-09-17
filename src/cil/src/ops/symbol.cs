//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cil
    {
        [MethodImpl(Inline), Op]
        public static OpCodeSymbol symbol(ILOpCode id)
            => new OpCodeSymbol(id);

        [MethodImpl(Inline)]
        public static OpCodeSymbol symbol<K>(K k = default)
            where K : unmanaged, ICilOpCode<K>
                => new OpCodeSymbol((ILOpCode)(default(K).Id));
    }
}