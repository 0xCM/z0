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
            where T : unmanaged
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
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(0f));
            else if(typeof(T) == typeof(double))
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
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(1f));
            else if(typeof(T) == typeof(double))
                return generic<T>(ref asRef(1.0));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : unmanaged
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
            else if(typeof(T) == typeof(float))
                return generic<T>(float.MinValue);
            else if(typeof(T) == typeof(double))
                return generic<T>(double.MinValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
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
            else if(typeof(T) == typeof(float))
                return generic<T>(float.MaxValue);
            else if(typeof(T) == typeof(double))
                return generic<T>(double.MaxValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool signed<T>()
            where T : unmanaged
            => !(typeof(T) == typeof(byte)
                || typeof(T) == typeof(ushort)
                || typeof(T) == typeof(uint)
                || typeof(T) == typeof(ulong));
            

        [MethodImpl(Inline)]
        public static bool unsigned<T>()
            where T : unmanaged
                => (typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(ulong));
                        
        [MethodImpl(Inline)]
        public static bool floating<T>()
            where T : unmanaged
                => typeof(T) == typeof(float) || typeof(T) == typeof(double);

        [MethodImpl(Inline)]
        public static bool unsignedint<T>()
            where T : unmanaged
            => typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong);


        [MethodImpl(Inline)]
        public static bool signedint<T>()
            where T : unmanaged
            => typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long);

        [MethodImpl(Inline)]
        public static bool integral<T>()
            where T : unmanaged
                => signedint<T>() || unsignedint<T>();

        [MethodImpl(Inline)]
        public static ByteSize size<T>()
            where T : unmanaged
                => SizeOf<T>.Size;

        [MethodImpl(Inline)]
        public static BitSize bitsize<T>()
            where T : unmanaged
                => Unsafe.SizeOf<T>()* 8;

    }
}