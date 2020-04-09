//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static As;
    using static Seed;

    partial class Numeric
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T contract<T>(T src, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Z0.Scalar.contract(uint8(src), uint8(max)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Z0.Scalar.contract(uint16(src), (uint16(max))));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Z0.Scalar.contract(uint32(src), (uint32(max))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Z0.Scalar.contract(uint64(src), (uint64(max))));
            else
                throw Unsupported.define<T>();
        }
    }
}