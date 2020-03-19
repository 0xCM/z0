//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Reflection;

    using static Root;

    using K = Classes;

    partial class Fixed
    {
        [MethodImpl(Inline)]
        public static UnaryOp1 fix(MethodInfo f, K.UnaryOp<bit> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOp<sbyte> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOp<byte> k) => fix(Delegates.create(f,k));
        
        [MethodImpl(Inline)]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOp<short> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOp<ushort> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOp<uint> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOp<int> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOp<ulong> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOp<long> k ) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp1 fix(MethodInfo f, K.BinaryOp<bit> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOp<sbyte> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOp<byte> k) => fix(Delegates.create(f,k));
        
        [MethodImpl(Inline)]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOp<short> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOp<ushort> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOp<uint> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOp<int> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOp<ulong> k) => fix(Delegates.create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOp<long> k ) => fix(Delegates.create(f,k));
    }
}