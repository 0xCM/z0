//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Dataset<F>
        where F : unmanaged, Enum
    {

    }

    public readonly struct Dataset<F,C> : IIndex<Dataset<F,C>,C>
        where F : unmanaged, Enum
    {
        readonly C[] Data;

        public Dataset(C[] src)
        {
            Data = src;
        }
        public ref C this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length 
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public C[] Content
        {
            get => Data;
        }
    }
}