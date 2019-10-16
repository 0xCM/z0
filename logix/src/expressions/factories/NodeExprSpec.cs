//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    partial class Bitwise
    {

        public static class NodeExprSpec
        {
            [MethodImpl(Inline)]
            public static OrNodeExpr and<T>(params ILogicOp[] terms)
                where T : unmanaged
                    => new OrNodeExpr(terms);

            [MethodImpl(Inline)]
            public static OrNodeExpr or<T>(params ILogicOp[] terms)
                where T : unmanaged
                    => new OrNodeExpr(terms);

            [MethodImpl(Inline)]
            public static AndNodeExpr<T> and<T>(params IOpExpr<T>[] terms)
                where T : unmanaged
                    => new AndNodeExpr<T>(terms);

            [MethodImpl(Inline)]
            public static OrNodeExpr<T> or<T>(params IOpExpr<T>[] terms)
                where T : unmanaged
                    => new OrNodeExpr<T>(terms);
     
            /// <summary>
            /// Defines a test expression for a binary operator
            /// </summary>
            /// <param name="test">The logical operator to use for the test</param>
            /// <param name="control">The control expression</param>
            /// <param name="subject">The test subject</param>
            /// <typeparam name="T">The operand type</typeparam>
            [MethodImpl(Inline)]
            public static BinaryTestExpr<T> test<T>(BinaryLogicKind test, IExpr<T> control, BinaryLogicExpr<T> subject)
                where T : unmanaged
                    => new BinaryTestExpr<T>(test,control,subject);

            /// <summary>
            /// Defines a test expression for a unary operator
            /// </summary>
            /// <param name="test">The logical operator to use for the test</param>
            /// <param name="control">The control expression</param>
            /// <param name="subject">The test subject</param>
            /// <typeparam name="T">The operand type</typeparam>
            [MethodImpl(Inline)]
            public static UnaryTestExpr<T> test<T>(BinaryLogicKind test, IExpr<T> control, UnaryLogicExpr<T> subject)
                where T : unmanaged
                    => new UnaryTestExpr<T>(test,control,subject);

            /// <summary>
            /// Defines a test expression for a mixed operator
            /// </summary>
            /// <param name="test">The logical operator to use for the test</param>
            /// <param name="control">The control expression</param>
            /// <param name="subject">The test subject</param>
            /// <typeparam name="T">The operand type</typeparam>
            [MethodImpl(Inline)]
            public static ShiftTestExpr<T> test<T>(BinaryLogicKind test, IExpr<T> control, BitShiftExpr<T> subject)
                where T : unmanaged
                    => new ShiftTestExpr<T>(test,control,subject);
     
        }
    }
}
