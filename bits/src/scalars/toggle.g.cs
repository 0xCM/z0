//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {

        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, byte pos)
            where T : struct
        {
            if(typematch<T,sbyte>())
                Bits.toggle(ref int8(ref src), pos);
            else if(typematch<T,byte>())
                Bits.toggle(ref uint8(ref src), pos);
            else if(typematch<T,short>())
                Bits.toggle(ref int16(ref src), pos);
            else if(typematch<T,ushort>())
                Bits.toggle(ref uint16(ref src), pos);
            else if(typematch<T,int>())
                Bits.toggle(ref int32(ref src), pos);
            else if(typematch<T,uint>())
                Bits.toggle(ref uint32(ref src), pos);
            else if(typematch<T,long>())
                Bits.toggle(ref int64(ref src), pos);
            else if(typematch<T,ulong>())
                Bits.toggle(ref uint64(ref src), pos);
            else if(typematch<T,float>())
                Bits.toggle(ref float32(ref src), pos);
            else if(typematch<T,double>())
                Bits.toggle(ref float64(ref src), pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }


    }
}