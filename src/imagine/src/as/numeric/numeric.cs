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

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte int8<T>(T src)
            => As<T,sbyte>(ref src);        

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte uint8<T>(T src)
            => As<T,byte>(ref src);        

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static short int16<T>(T src)
            => As<T,short>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort uint16<T>(T src)
            => As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int int32<T>(T src)
            => As<T,int>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint uint32<T>(T src)
            => As<T,uint>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static long int64<T>(T src)
            => As<T,long>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong uint64<T>(T src)
            => As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UInt128 uint128<T>(T src)
            => As<T,UInt128>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static float float32<T>(T src)
            => As<T,float>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static double float64<T>(T src)
            => As<T,double>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static decimal float128<T>(T src)        
            => As<T,decimal>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static char char16<T>(T src)        
            => As<T,char>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool bool8<T>(T src)
            => As<T,bool>(ref src);        

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref sbyte int8<T>(ref T src)
            => ref As<T,sbyte>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte uint8<T>(ref T src)
            => ref As<T,byte>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref short int16<T>(ref T src)
            => ref As<T,short>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort uint16<T>(ref T src)
            => ref As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref int int32<T>(ref T src)
            => ref As<T,int>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint uint32<T>(ref T src)
            => ref As<T,uint>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref long int64<T>(ref T src)
            => ref As<T,long>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong uint64<T>(ref T src)
            => ref As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref float float32<T>(ref T src)
            => ref As<T,float>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref double float64<T>(ref T src)
            => ref As<T,double>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref decimal float128<T>(ref T src)
            => ref As<T,decimal>(ref src);
 
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => As<T?, sbyte?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte? uint8<T>(T? src)
            where T : unmanaged
                => As<T?, byte?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static short? int16<T>(T? src)
            where T : unmanaged
                => As<T?, short?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => As<T?, ushort?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => As<T?, int?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => As<T?, uint?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static long? int64<T>(T? src)
            where T : unmanaged
                => As<T?, long?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => As<T?, ulong?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static float? float32<T>(T? src)
            where T : unmanaged
                => As<T?, float?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => As<T?, double?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static decimal? float128<T>(T? src)
            where T : unmanaged
                => As<T?, decimal?>(ref src);
    }
}