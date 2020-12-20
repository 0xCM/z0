//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TypeCodeIndex
    {
        readonly Type[] Data;

        [MethodImpl(Inline)]
        internal TypeCodeIndex(Type[] src)
            => Data = src;

        public ref readonly Type this[TypeCode code]
        {
            [MethodImpl(Inline)]
            get => ref Data[(int)code];
        }
    }
}