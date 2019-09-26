//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {

        /// <summary>
        /// Decrements the source value 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.dec(int8(src)));
            else if(typematch<T,byte>())
                return generic<T>(math.dec(uint8(src)));
            else if(typematch<T,short>())
                return generic<T>(math.dec(int16(src)));
            else if(typematch<T,ushort>())
                return generic<T>(math.dec(uint16(src)));
            else if(typematch<T,int>())
                return generic<T>(math.dec(int32(src)));
            else if(typematch<T,uint>())
                return generic<T>(math.dec(uint32(src)));
            else if(typematch<T,long>())
                return generic<T>(math.dec(int64(src)));
            else if(typematch<T,ulong>())
                return generic<T>(math.dec(uint64(src)));
            else if(typematch<T,float>())
                return generic<T>(fmath.dec(float32(src)));
            else if(typematch<T,double>())
                return generic<T>(fmath.dec(float64(src)));
            else            
                 throw unsupported<T>();                
        }           

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                math.dec(ref int8(ref src));
            else if(typematch<T,byte>())
                math.dec(ref uint8(ref src));
            else if(typematch<T,short>())
                math.dec(ref int16(ref src));
            else if(typematch<T,ushort>())
                math.dec(ref uint16(ref src));
            else if(typematch<T,int>())
                math.dec(ref int32(ref src));
            else if(typematch<T,uint>())
                math.dec(ref uint32(ref src));
            else if(typematch<T,long>())
                math.dec(ref int64(ref src));
            else if(typematch<T,ulong>())
                math.dec(ref uint64(ref src));
            else if(typematch<T,float>())
                fmath.dec(ref float32(ref src));
            else if(typematch<T,double>())
                fmath.dec(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           

    }
}