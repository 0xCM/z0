//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiSetKind.Bits)]
    public partial class Bits
    {
        const NumericKind Closure = Konst.UnsignedInts;

        /// <summary>
        /// Wraps a bitview around a generic reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The generic type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitEditor<T> editor<T>(in T src)
            where T : unmanaged
                => new BitEditor<T>(src);
    }

    [ApiHost(ApiSetKind.Bits | ApiSetKind.Generic)]
    public partial class gbits
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static NumericBitLogic<T> bitlogic<T>()
            where T : unmanaged
                => default(NumericBitLogic<T>);

    }

    [ApiHost]
    public partial class BitLogixOps
    {

    }

    public static partial class XTend
    {

    }

    public static partial class XBits
    {

    }
}