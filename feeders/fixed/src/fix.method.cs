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

    using K = OpClass;

    partial class Fixed
    {        
        [MethodImpl(Inline)]
        static UnaryOp<T> create<T>(MethodInfo src, K.UnaryOp<T> k)
            where T : unmanaged
                => create<UnaryOp<T>>(src);

        [MethodImpl(Inline)]
        static BinaryOp<T> create<T>(MethodInfo src, K.BinaryOp<T> K)
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
        public static UnaryOp1 fix(MethodInfo f, K.UnaryOp<bit> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOp<sbyte> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp8 fix(MethodInfo f, K.UnaryOp<byte> k) => fix(create(f,k));
        
        [MethodImpl(Inline)]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOp<short> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp16 fix(MethodInfo f, K.UnaryOp<ushort> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOp<uint> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp32 fix(MethodInfo f, K.UnaryOp<int> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOp<ulong> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static UnaryOp64 fix(MethodInfo f, K.UnaryOp<long> k ) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp1 fix(MethodInfo f, K.BinaryOp<bit> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOp<sbyte> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp8 fix(MethodInfo f, K.BinaryOp<byte> k) => fix(create(f,k));
        
        [MethodImpl(Inline)]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOp<short> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp16 fix(MethodInfo f, K.BinaryOp<ushort> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOp<uint> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp32 fix(MethodInfo f, K.BinaryOp<int> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOp<ulong> k) => fix(create(f,k));

        [MethodImpl(Inline)]
        public static BinaryOp64 fix(MethodInfo f, K.BinaryOp<long> k ) => fix(create(f,k));
    }
}