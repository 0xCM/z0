//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct As
    {
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(char src)
            => As<char,T>(ref src);                 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(bool src)
            => As<bool,T>(ref src);                 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(sbyte src)
            => As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(byte src)
            => As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(short src)
            => As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(ushort src)
            => As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(int src)
            => As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(uint src)
            => As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(long src)
            => As<long,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(ulong src)
            => As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(float src)
            => As<float,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(double src)
            => As<double,T>(ref src);            

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(decimal src)
            => As<decimal,T>(ref src);            

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref sbyte src)
            => ref As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref byte src)
            => ref As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref short src)
            => ref As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref ushort src)
            => ref As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref int src)
            => ref As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref uint src)
            => ref As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref ulong src)
            => ref As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref decimal src)
            => ref As<decimal,T>(ref src);
 

    }
}