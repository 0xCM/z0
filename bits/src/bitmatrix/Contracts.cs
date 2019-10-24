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


    public interface IBitSquare
    {

    }

    public interface IBitSquare<T> : IBitSquare
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

    public interface IBitSquare<M,T> : IBitSquare<T>
        where M : IBitSquare<M,T>
        where T : unmanaged
    {
        
    }

}