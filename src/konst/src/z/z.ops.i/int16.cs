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

    partial struct z
    {                
        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static short int16<T>(T src)
            => As<T,short>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static short? int16<T>(T? src)
            where T : unmanaged
                => As<T?, short?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref short int16<T>(ref T src)
            => ref As<T,short>(ref src);                

        [MethodImpl(Inline), Op]
        public static short int16(sbyte src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short int16(byte src)        
            => (short)src;
        
        [MethodImpl(Inline), Op]
        public static short int16(short src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short int16(ushort src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short int16(int src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short int16(uint src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short int16(long src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short int16(ulong src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short int16(float src)
            => (short)((int)src);

        [MethodImpl(Inline), Op]
        public static short int16(double src)
            => (short)((long)src);        

    }
}