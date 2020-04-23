//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
 
    using static Seed;

    using K = Kinds;

    partial class Fixed
    {        
        [MethodImpl(Inline), Op]
        public static UnaryOp1 fix(MethodInfo f, K.UnaryOpClass<bit> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOpClass<sbyte> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOpClass<byte> k) => fix(create(f,k));
        
        [MethodImpl(Inline), Op]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOpClass<short> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOpClass<ushort> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOpClass<uint> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOpClass<int> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOpClass<ulong> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOpClass<long> k ) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp1 fix(MethodInfo f, K.BinaryOpClass<bit> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOpClass<sbyte> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOpClass<byte> k) => fix(create(f,k));
        
        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOpClass<short> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOpClass<ushort> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOpClass<uint> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOpClass<int> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOpClass<ulong> k) => fix(create(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOpClass<long> k ) => fix(create(f,k));
    }
}