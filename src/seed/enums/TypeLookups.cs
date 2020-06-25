//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    
    [ApiHost]
    public readonly struct TypeLookups
    {        
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Type match<T>(in NumericTx10 src)
            => src.T.match<T>();

        [MethodImpl(Inline), Op]
        static unsafe ref readonly Type fetchU(in NumericTx10 lu, byte index)
        {
            var address = Root.location(lu);
            var offset = (byte)index;
            var pType = (address + offset).Pointer<ulong>();
            return ref As.@ref<ulong,Type>(pType);                    
        }

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in TypeIndex lu, TypeCode index)
            => ref lu[index];        

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in TypeCodes lu, TypeCode index)
            => ref lu[index];        

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in NumericTx10 lu, byte index)
            => ref fetchU(lu,index);

        [MethodImpl(Inline), Op]
        public static TypeCode test_1(in NumericTx10 lu, in TypeCodes codes, in TypeIndex index)
        {
            byte i = 3;
            var t = type(lu, i);
            return  codes.Lookup(i);
        }

        [MethodImpl(Inline), Op]
        public static Type test_2(in NumericTx10 lu, in TypeCodes codes, in TypeIndex index)
        {
            byte i = 5;
            var t1 = type(lu, i);
            var c1 = codes.Lookup(i);
            var t2 = index[(TypeCode)c1];
            return t2;
        }

        [MethodImpl(Inline), Op]
        public static bool test_3(in TypeCodes codes)
        {
            byte i = 5;
            var t2 = codes[(TypeCode)i];
            var ok = t2.Name == "Byte";
            return ok;
        }

        [MethodImpl(Inline), Op]
        public static TypeCodes codes()
            => new TypeCodes(0); 
        
        [MethodImpl(Inline), Op]
        public static TypeIndex index()
            => TypeCodes.Index();
    }
}