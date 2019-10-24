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


    public struct PrimalSquare<T> : IBitSquare<T>
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