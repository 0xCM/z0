//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static partial class mklx
    {
        /// <summary>
        /// Initializes a new VslStream for rng
        /// </summary>
        /// <param name="brng">The rng that will power the stream</param>
        /// <param name="seed">The initial state of the rng, if any</param>
        /// <param name="index">The stream index, if any</param>
        [MethodImpl(Inline)]
        internal static VslStream NewStream(this Brng brng, uint seed = 0, int index = 0)
        {
            IntPtr stream = IntPtr.Zero;
            VSL.vslNewStream(ref stream, brng + index, seed).ThrowOnError();
            return stream;
        }

        /// <summary>
        /// Gets the mkl brng identifier associated with a stream
        /// </summary>
        /// <param name="stream">The source stream</param>
        [MethodImpl(Inline)]
        internal static Brng Brng(this VslStream stream)
            => VSL.vslGetStreamStateBrng(stream);

        /// <summary>
        /// Gets the intel brng identifier associated with system rng classifier
        /// </summary>
        /// <param name="src">The mkl brng identifier</param>
        [MethodImpl(Inline)]
        internal static Brng ToBrng(this RngKind src)
            => (Brng)src;

        /// <summary>
        /// Gets the system rng classifier associated with a mkl brng
        /// </summary>
        /// <param name="src">The mkl brng identifier</param>
        [MethodImpl(Inline)]
        internal static RngKind ToRngKind(this Brng src)
            => (RngKind)src;

        /// <summary>
        /// Gets system rng classifier associated with a stream
        /// </summary>
        /// <param name="stream">The source stream</param>
        [MethodImpl(Inline)]
        internal static RngKind RngKind(this VslStream stream)
            => stream.Brng().ToRngKind();
    }
}