//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        public static void require(bool invariant)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed");
        }

        public static void require(bool invariant, string msg)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed: {msg}");
        }

        public static void require<N>(ulong src)
            where N : unmanaged, ITypeNat
                => require(value<N>() == src, $"The source value {src} does not match the required natural value {value<N>()}");        

        public static void require<N>(int src)
            where N : unmanaged, ITypeNat
                => require<N>((ulong)src);
    }
}