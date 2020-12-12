//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {
        /// <summary>
        /// Characterizes a structural transformation function
        /// </summary>
        /// <typeparam name="A">The source domain type</typeparam>
        /// <typeparam name="B">The target domain type</typeparam>
        [Free, SFx]
        public interface IProjector<A,B> : IFunc<A,B>
        {

        }

        /// <summary>
        /// Characterizes a projector that is also a unary operator
        /// </summary>
        /// <typeparam name="T"></typeparam>
        [Free, SFx]
        public interface IProjector<T> : IProjector<T,T>, IUnaryOp<T>
        {

        }
    }
}