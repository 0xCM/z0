//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static bool nonzero<T>(T src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return math.nonzero(int8(in src));
            else if(typematch<T,byte>())
                return math.nonzero(uint8(in src));
            else if(typematch<T,short>())
                return math.nonzero(int16(in src));
            else if(typematch<T,ushort>())
                return math.nonzero(uint16(in src));
            else if(typematch<T,int>())
                return math.nonzero(int32(in src));
            else if(typematch<T,uint>())
                return math.nonzero(uint32(in src));
            else if(typematch<T,long>())
                return math.nonzero(int64(in src));
            else if(typematch<T,ulong>())
                return math.nonzero(uint64(in src));
            else if(typematch<T,float>())
                return math.nonzero(float32(in src));
            else if(typematch<T,double>())
                return math.nonzero(float64(in src));
            else            
                throw unsupported<T>();
        }

 

    }

}