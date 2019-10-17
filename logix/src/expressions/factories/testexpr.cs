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
    
    public static class TestExprSpec
    {
        /// <summary>
        /// Defines a test expression for a binary operator
        /// </summary>
        /// <param name="test">The logical operator to use for the test</param>
        /// <param name="control">The control expression</param>
        /// <param name="subject">The test subject</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryTestExpr<T> test<T>(BinaryLogicOpKind test, IExpr<T> control, BinaryLogicOp<T> subject)
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
        public static UnaryTestExpr<T> test<T>(BinaryLogicOpKind test, IExpr<T> control, UnaryLogicOp<T> subject)
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
        public static ShiftTestExpr<T> test<T>(BinaryLogicOpKind test, IExpr<T> control, BitShiftOp<T> subject)
            where T : unmanaged
                => new ShiftTestExpr<T>(test,control,subject);
    
    }

}
