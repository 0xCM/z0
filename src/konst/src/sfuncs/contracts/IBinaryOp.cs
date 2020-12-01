//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {
        /// <summary>
        /// Characterizes a structural binary operator
        /// </summary>
        /// <typeparam name="A">The operand type</typeparam>
        [Free, SFx]
        public interface IBinaryOp<A> : IFunc<A,A,A>
        {
            new BinaryOp<A> Operation
                => (this as IFunc<A,A,A>).Operation.ToBinaryOp();
        }

        [Free, SFx]
        public interface IBinaryOpIn<A> : IFuncIn<A,A,A>
        {

        }
    }
}