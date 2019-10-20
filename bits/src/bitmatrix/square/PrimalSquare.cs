//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public interface IPrimalSquare
    {

    }

    public interface IPrimalSquare<T> : IPrimalSquare
        where T : unmanaged
    {
        /// <summary>
        /// The data enclosed by the matrix
        /// </summary>
        T[] Rows {get;}

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        ref T Head {get;}

        void Load(int row, out Vector256<T> dst);
    }

    public interface IPrimalSquare<M,T> : IPrimalSquare<T>
        where M : IPrimalSquare<M,T>
        where T : unmanaged
    {
        
    }


    public struct PrimalSquare<T> : IPrimalSquare<T>
        where T : unmanaged
    {
        T[] rows;

        public PrimalSquare(T[] rows)
        {
            this.rows = rows;
        }

        public T[] Rows
        {
            [MethodImpl(Inline)]
            get => rows;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref rows[0];
        }

        public void Load(int row, out Vector256<T> dst)
            => ginx.vloadu(in Rows[row], out dst);
    }
}