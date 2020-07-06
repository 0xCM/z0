//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct core
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static byte uint8<T>(T src)
            => As<T,byte>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ushort uint16<T>(T src)
            => As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint uint32<T>(T src)
            => As<T,uint>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ulong uint64<T>(T src)
            => As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static sbyte int8<T>(T src)
            => As<T,sbyte>(ref src);        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static short int16<T>(T src)
            => As<T,short>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static int int32<T>(T src)
            => As<T,int>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static long int64<T>(T src)
            => As<T,long>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static float float32<T>(T src)
            => As<T,float>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static double float64<T>(T src)
            => As<T,double>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static decimal float128<T>(T src)
            => As<T,decimal>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static char char16<T>(T src)        
            => As<T,char>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool bool8<T>(T src)
            => As<T,bool>(ref src);        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(char src)
            => As<char,T>(ref src);                 

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(bool src)
            => As<bool,T>(ref src);                 

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(sbyte src)
            => As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(byte src)
            => As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(short src)
            => As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(ushort src)
            => As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(int src)
            => As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(uint src)
            => As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(long src)
            => As<long,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(ulong src)
            => As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(float src)
            => As<float,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(double src)
            => As<double,T>(ref src);            

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(decimal src)
            => As<decimal,T>(ref src);        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<sbyte,sbyte,sbyte> src)
            where T : unmanaged
                => ref edit<Func<sbyte,sbyte,sbyte>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<byte,byte,byte> src)
            where T : unmanaged
                => ref edit<Func<byte,byte,byte>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<ushort,ushort,ushort> src)
            where T : unmanaged
                => ref edit<Func<ushort,ushort,ushort>, Func<T,T,T>>(src);


        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<short,short,short> src)
            where T : unmanaged
                => ref edit<Func<short,short,short>, Func<T,T,T>>(src);


        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<int,int,int> src)
            where T : unmanaged
                => ref edit<Func<int,int,int>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<uint,uint,uint> src)
            where T : unmanaged
                => ref edit<Func<uint,uint,uint>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<long,long,long> src)
            where T : unmanaged
                => ref edit<Func<long,long,long>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<ulong,ulong,ulong> src)
            where T : unmanaged
                => ref edit<Func<ulong,ulong,ulong>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<float,float,float> src)
            where T : unmanaged
                => ref edit<Func<float,float,float>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,T> generic<T>(in Func<double,double,double> src)
            where T : unmanaged
                => ref edit<Func<double,double,double>, Func<T,T,T>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,bool> generic<T>(in Func<byte,byte,bool> src)
            where T : unmanaged
                => ref edit<Func<byte,byte,bool>, Func<T,T,bool>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,bool> generic<T>(in Func<ulong,ulong,bool> src)
            where T : unmanaged
                => ref edit<Func<ulong,ulong,bool>, Func<T,T,bool>>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Func<T,T,bool> generic<T>(in Func<decimal,decimal,bool> src)
            where T : unmanaged
                => ref edit<Func<decimal,decimal,bool>, Func<T,T,bool>>(src);                
    }
}