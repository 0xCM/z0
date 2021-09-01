//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        public struct TypeCode
        {
            ulong Data;

            [MethodImpl(Inline)]
            internal TypeCode(ulong data)
            {
                Data = data;
            }
        }
    }
}