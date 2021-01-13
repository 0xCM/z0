//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;

    using static SFx;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {
        /// <summary>
        /// Characterizes a vectorized binary operator over 128-bit operands
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        [Free, SFx]
        public interface IBinaryOp128<T> : IBinaryOp<Vector128<T>>, IFunc128<T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a vectorized binary operator over 256-bit operands
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        [Free, SFx]
        public interface IBinaryOp256<T> : IBinaryOp<Vector256<T>>, IFunc256<T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a vectorized binary operator over 256-bit operands
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        [Free, SFx]
        public interface IBinaryOp512<T> : IBinaryOp<Vector512<T>>, IFunc512<T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a vectorized binary operator over 128-bit operands that is accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        [Free, SFx]
        public interface IBinaryOp128D<T> : IBinaryOp128<T>, IBinaryOp<T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a vectorized binary operator over 256-bit operands that is accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        [Free, SFx]
        public interface IBinaryOp256D<T> : IBinaryOp256<T>, IBinaryOp<T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a vectorized binary operator over 256-bit operands that is accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        [Free, SFx]
        public interface IBinaryOp512D<T> : IBinaryOp512<T>, IBinaryOp<T>
            where T : unmanaged
        {

        }
    }
}