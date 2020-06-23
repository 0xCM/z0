//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    public struct UInt128
    {
        Vector128<ulong> Storage;

        [MethodImpl(Inline)]
        public static implicit operator UInt128((ulong lo, ulong hi) src)
            => new UInt128(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static implicit operator UInt128(Vector128<ulong> src)
            => new UInt128(src);

        [MethodImpl(Inline)]
        public UInt128(ulong lo, ulong hi)
        {            
            Storage = Vector128.Create(lo,hi);
        }

        [MethodImpl(Inline)]
        public UInt128(Vector128<ulong> src)
        {            
            Storage = src;
        }

        public ulong Lo
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(0);
        }
    
        public ulong Hi
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(1);
        }   

        public Vector128<ulong> Data
        {
            [MethodImpl(Inline)]
            get => Storage;
        } 
    }
}