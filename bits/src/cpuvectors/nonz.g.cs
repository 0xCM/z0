//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    using static As;
    

    partial class gbits
    {
        /// <summary>
        /// Returns true if at least one of the components of the source
        /// vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool nonz<T>(in Vec128<T> src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return Bits.nonz(in int8(in src));
            else if(typematch<T,byte>())
                return Bits.nonz(in uint8(in src));
            else if(typematch<T,short>())
                return Bits.nonz(in int16(in src));
            else if(typematch<T,ushort>())
                return Bits.nonz(in uint16(in src));
            else if(typematch<T,int>())
                return Bits.nonz(in int32(in src));
            else if(typematch<T,uint>())
                return Bits.nonzero(in uint32(in src));
            else if(typematch<T,long>())
                return Bits.nonz(in int64(in src));
            else if(typematch<T,ulong>())
                return Bits.nonz(in uint64(in src));
            else if(typematch<T,float>())
                return Bits.nonz(in float32(in src));
            else if(typematch<T,double>())
                return Bits.nonz(in float64(in src));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Returns true if at least one of the components of the source
        /// vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool nonz<T>(in Vec256<T> src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return Bits.nonz(in int8(in src));
            else if(typematch<T,byte>())
                return Bits.nonz(in uint8(in src));
            else if(typematch<T,short>())
                return Bits.nonz(in int16(in src));
            else if(typematch<T,ushort>())
                return Bits.nonz(in uint16(in src));
            else if(typematch<T,int>())
                return Bits.nonz(in int32(in src));
            else if(typematch<T,uint>())
                return Bits.nonz(in uint32(in src));
            else if(typematch<T,long>())
                return Bits.nonz(in int64(in src));
            else if(typematch<T,ulong>())
                return Bits.nonz(in uint64(in src));
            else if(typematch<T,float>())
                return Bits.nonz(in float32(in src));
            else if(typematch<T,double>())
                return Bits.nonz(in float64(in src));
            else 
                throw unsupported<T>();
        }         

    }

}