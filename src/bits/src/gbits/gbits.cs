//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;


    [ApiHost(ApiSetKind.Bits | ApiSetKind.Generic)]
    public partial class gbits
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static NumericBitLogic<T> bitlogic<T>()
            where T : unmanaged
                => default(NumericBitLogic<T>);

    }

    public static partial class XTend
    {

    }

    public static partial class XBits
    {

    }
}