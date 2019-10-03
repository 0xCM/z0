//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix16 A)
            => BitGraph.FromMatrix<byte,N16,byte>(BitMatrix<N16,N16,byte>.Load(A.Bytes));            

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix32 A)
            => BitGraph.FromMatrix<byte,N32,byte>(BitMatrix<N32,N32,byte>.Load(A.Bytes));

        /// <summary>
        /// Constructs a 64-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix64 A)
            => BitGraph.FromMatrix<byte,N32,byte>(BitMatrix<N32,N32,byte>.Load(A.Bytes));            



    }

}