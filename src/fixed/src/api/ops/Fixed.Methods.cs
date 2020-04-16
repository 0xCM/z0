//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;

    using static Seed;

    using K = Kinds;

    partial class Fixed
    {        
        [MethodImpl(Inline)]
        static UnaryOp<T> create<T>(MethodInfo src, K.UnaryOpClass<T> k)
            where T : unmanaged
                => create<UnaryOp<T>>(src);

        [MethodImpl(Inline)]
        static BinaryOp<T> create<T>(MethodInfo src, K.BinaryOpClass<T> K)
            where T : unmanaged
                => create<BinaryOp<T>>(src);

        /// <summary>
        /// Creates a generic delegate for a static method
        /// </summary>
        /// <typeparam name="D">The type of the constructed delegate</typeparam>
        /// <param name="m">The method that will be invoked when delegate is activated</param>
        static D create<D>(MethodInfo m)
            where D : Delegate
        {
            var argTypes = m.ParameterTypes().ToArray();
            var dType
                = m.IsAction()
                ? Expression.GetActionType(argTypes)
                : Expression.GetFuncType(argTypes.Concat(Arrays.from(m.ReturnType)).ToArray());
            return (D)Delegate.CreateDelegate(typeof(D), null, m);
        }

        [MethodImpl(Inline)]
        public static UnaryOp1 fix(MethodInfo f, K.UnaryOpClass<bit> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOpClass<sbyte> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOpClass<byte> k) => fix(create(f,k));
        
        [MethodImpl(Inline)]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOpClass<short> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOpClass<ushort> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOpClass<uint> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOpClass<int> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOpClass<ulong> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOpClass<long> k ) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp1 fix(MethodInfo f, K.BinaryOpClass<bit> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOpClass<sbyte> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOpClass<byte> k) => fix(create(f,k));
        
        [MethodImpl(Inline)]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOpClass<short> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOpClass<ushort> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOpClass<uint> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOpClass<int> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOpClass<ulong> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOpClass<long> k ) => fix(create(f,k));
    }
}