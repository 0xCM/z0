//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;


    using static zfunc;
    using static As;
    using static AsIn;
    

    partial class gbits
    {

        [MethodImpl(Inline)]
        public static Vec128<T> vflip<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(Bits.vflip(in int8(in src)));
            else if(typematch<T,byte>())
                return generic<T>(Bits.vflip(in uint8(in src)));
            else if(typematch<T,short>())
                return generic<T>(Bits.vflip(in int16(in src)));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.vflip(in uint16(in src)));
            else if(typematch<T,int>())
                return generic<T>(Bits.vflip(in int32(in src)));
            else if(typematch<T,uint>())
                return generic<T>(Bits.vflip(in uint32(in src)));
            else if(typematch<T,long>())
                return generic<T>(Bits.vflip(in int64(in src)));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.flip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vflip<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(Bits.vflip(in int8(in src)));
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.vflip(in uint8(in src)));
            else if(typematch<T,short>())
                return generic<T>(Bits.vflip(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.vflip(in uint16(in src)));
            else if(typematch<T,int>())
                return generic<T>(Bits.vflip(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.vflip(in uint32(in src)));
            else if(typematch<T,long>())
                return generic<T>(Bits.vflip(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.vflip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }
         



    }
}