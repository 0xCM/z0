//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class NatClaims
    {
        /// <summary>
        /// Captures evidence that k % 2 == 0
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        public readonly struct NatEven<K> : INatEven<K>
            where K: unmanaged, ITypeNat
        {
            static K k => default;

            public static string Description => $"{k} % {2} = {0}";

            [MethodImpl(Inline)]
            public NatEven(K k)
                => root.require(NatCalc.even(k), () => Description);

            public ulong NatValue
                => k.NatValue;

            public override string ToString()
                => Description;
        }
    }
}