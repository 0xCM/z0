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
    using static Constants;
    
    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : struct
        {        
            if(typematch<T,sbyte>())
                return generic<T>(ref asRef((sbyte)0));
            else if(typematch<T,byte>())
                return generic<T>(ref asRef((byte)0));
            else if(typematch<T,short>())
                return generic<T>(ref asRef((short)0));
            else if(typematch<T,ushort>())
                return generic<T>(ref asRef((ushort)0));
            else if(typematch<T,int>())
                return generic<T>(ref asRef(0));
            else if(typematch<T,uint>())
                return generic<T>(ref asRef(0u));
            else if(typematch<T,long>())
                return generic<T>(ref asRef(0L));
            else if(typematch<T,ulong>())
                return generic<T>(ref asRef(0ul));
            else if(typematch<T,float>())
                return generic<T>(ref asRef(0f));
            else if(typematch<T,double>())
                return generic<T>(ref asRef(0.0));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T one<T>()
        {        
            if(typematch<T,sbyte>())
                return generic<T>(ref asRef((sbyte)1));
            else if(typematch<T,byte>())
                return generic<T>(ref asRef((byte)1));
            else if(typematch<T,short>())
                return generic<T>(ref asRef((short)1));
            else if(typematch<T,ushort>())
                return generic<T>(ref asRef((ushort)1));
            else if(typematch<T,int>())
                return generic<T>(ref asRef(1));
            else if(typematch<T,uint>())
                return generic<T>(ref asRef(1u));
            else if(typematch<T,long>())
                return generic<T>(ref asRef(1L));
            else if(typematch<T,ulong>())
                return generic<T>(ref asRef(1ul));
            else if(typematch<T,float>())
                return generic<T>(ref asRef(1f));
            else if(typematch<T,double>())
                return generic<T>(ref asRef(1.0));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>(sbyte.MinValue);
            else if(typematch<T,byte>())
                return generic<T>(byte.MinValue);
            else if(typematch<T,short>())
                return generic<T>(short.MinValue);
            else if(typematch<T,ushort>())
                return generic<T>(ushort.MinValue);
            else if(typematch<T,int>())
                return generic<T>(int.MinValue);
            else if(typematch<T,uint>())
                return generic<T>(uint.MinValue);
            else if(typematch<T,long>())
                return generic<T>(long.MinValue);
            else if(typematch<T,ulong>())
                return generic<T>(ulong.MinValue);
            else if(typematch<T,float>())
                return generic<T>(float.MinValue);
            else if(typematch<T,double>())
                return generic<T>(double.MinValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>(sbyte.MaxValue);
            else if(typematch<T,byte>())
                return generic<T>(byte.MaxValue);
            else if(typematch<T,short>())
                return generic<T>(short.MaxValue);
            else if(typematch<T,ushort>())
                return generic<T>(ushort.MaxValue);
            else if(typematch<T,int>())
                return generic<T>(int.MaxValue);
            else if(typematch<T,uint>())
                return generic<T>(uint.MaxValue);
            else if(typematch<T,long>())
                return generic<T>(long.MaxValue);
            else if(typematch<T,ulong>())
                return generic<T>(ulong.MaxValue);
            else if(typematch<T,float>())
                return generic<T>(float.MaxValue);
            else if(typematch<T,double>())
                return generic<T>(double.MaxValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool signed<T>()
            where T : struct
        {
            if(typematch<T,sbyte>())
                return true;
            else if(typematch<T,byte>())
                return false;
            else if(typematch<T,short>())
                return true;
            else if(typematch<T,ushort>())
                return false;
            else if(typematch<T,int>())
                return true;
            else if(typematch<T,uint>())
                return false;
            else if(typematch<T,long>())
                return true;
            else if(typematch<T,ulong>())
                return false;
            else if(typematch<T,float>())
                return true;
            else if(typematch<T,double>())
                return true;
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool unsigned<T>()
            where T : struct
                => !signed<T>();

        [MethodImpl(Inline)]
        public static bool floating<T>()
            where T : struct
        {
            if(typematch<T,float>())
                return true;
            else if(typematch<T,double>())
                return true;
            else
                return false;
        }

        [MethodImpl(Inline)]
        public static bool integral<T>()
            where T : struct
                => !floating<T>();

        [MethodImpl(Inline)]
        public static ByteSize size<T>()
            where T : struct
                => SizeOf<T>.Size;

        [MethodImpl(Inline)]
        public static BitSize bitsize<T>()
            where T : struct
                => Unsafe.SizeOf<T>()* 8;

    }
}