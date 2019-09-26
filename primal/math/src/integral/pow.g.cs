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

        [MethodImpl(Inline)]
        public static T pow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                return gfp.pow(b,exp);
            else
                return ipow(b,exp);
        }

        [MethodImpl(Inline)]
        public static T ipow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.pow(ref int8(ref b), exp));
            else if(typematch<T,byte>())
                return generic<T>(math.pow(ref uint8(ref b), exp));
            else if(typematch<T,short>())
                return generic<T>(math.pow(ref int16(ref b), exp));
            else if(typematch<T,ushort>())
                return generic<T>(math.pow(ref uint16(ref b), exp));
            else if(typematch<T,int>())
                return generic<T>(math.pow(ref int32(ref b), exp));
            else if(typematch<T,uint>())
                return generic<T>(math.pow(ref uint32(ref b), exp));
            else if(typematch<T,long>())
                return generic<T>(math.pow(ref int64(ref b), exp));
            else if(typematch<T,ulong>())
                return generic<T>(math.ipow(ref uint64(ref b), exp));
            else            
               throw unsupported<T>();
            
         }           

        [MethodImpl(Inline)]
        public static ref T ipow<T>(ref T b, uint exp)
            where T : struct
        {
            if(typematch<T,sbyte>())
                math.pow(ref int8(ref b), exp);
            else if(typematch<T,byte>())
                math.pow(ref uint8(ref b), exp);
            else if(typematch<T,short>())
                math.pow(ref int16(ref b), exp);
            else if(typematch<T,ushort>())
                math.pow(ref uint16(ref b), exp);
            else if(typematch<T,int>())
                math.pow(ref int32(ref b), exp);
            else if(typematch<T,uint>())
                math.pow(ref uint32(ref b), exp);
            else if(typematch<T,long>())
                math.pow(ref int64(ref b), exp);
            else if(typematch<T,ulong>())
                math.ipow(ref uint64(ref b), exp);
            else            
               throw unsupported<T>();
            
            return ref b;
         }           

 
        [MethodImpl(Inline)]
        public static bool isPow2<T>(T src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return math.isPow2(int8(src));
            else if(typematch<T,byte>())
                return math.isPow2(uint8(src));
            else if(typematch<T,short>())
                return math.isPow2(int16(src));
            else if(typematch<T,ushort>())
                return math.isPow2(uint16(src));
            else if(typematch<T,int>())
                return math.isPow2(int32(src));
            else if(typematch<T,uint>())
                return math.isPow2(uint32(src));
            else if(typematch<T,long>())
                return math.isPow2(int64(src));
            else if(typematch<T,ulong>())
                return math.isPow2(uint64(src));
            else            
                throw unsupported<T>();
        }           

    }
}