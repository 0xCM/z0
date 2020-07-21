//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    
    using static z;

    [ApiHost]
    public readonly struct In
    {
       [MethodImpl(Inline)]
        public static ref T generic<S,T>(in S src)
            => ref As<S,T>(ref edit(in src));            
                    
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref sbyte int8<T>(in T src)
            => ref As<T,sbyte>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref byte uint8<T>(in T src)
            => ref As<T,byte>(ref edit(in src));            

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref short int16<T>(in T src)
            => ref As<T,short>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref ushort uint16<T>(in T src)
            => ref As<T,ushort>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref int int32<T>(in T src)
            => ref As<T,int>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref uint uint32<T>(in T src)
            => ref As<T,uint>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref long int64<T>(in T src)
            => ref As<T,long>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref ulong uint64<T>(in T src)
            => ref As<T,ulong>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref float float32<T>(in T src)
            => ref As<T,float>(ref edit(in src));
        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref double float64<T>(in T src)
            => ref As<T,double>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref decimal float128<T>(in T src)
        //     => ref As<T,decimal>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref char char16<T>(in T src)
        //     => ref As<T,char>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref bool bool8<T>(in T src)
        //     => ref As<T,bool>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in sbyte src)
        //     => ref As<sbyte,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in byte src)
        //     => ref As<byte,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in short src)
        //     => ref As<short,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in ushort src)
        //     => ref As<ushort,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in int src)
        //     => ref As<int,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in uint src)
        //     => ref As<uint,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in long src)
        //     => ref As<long,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in ulong src)
        //     => ref As<ulong,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in float src)
        //     => ref As<float,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in double src)
        //     => ref As<double,T>(ref edit(in src));           

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in decimal src)
        //     => ref As<decimal,T>(ref edit(in src));           

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in char src)
        //     => ref As<char,T>(ref edit(in src));

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref T generic<T>(in bool src)
        //     => ref As<bool,T>(ref edit(in src));

 
    }
}