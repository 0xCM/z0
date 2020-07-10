//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct NumericType10
    {
        public static NumericType10 Tx10 
        {
            [MethodImpl(Inline)]
           get => new NumericType10(0);
        }
        
        public readonly TxN<sbyte,byte,short,ushort,int,uint,long,ulong,float,double> T;
                
        [MethodImpl(Inline)]
        public NumericType10(int i)
        {
            T = Tx.T<sbyte,byte,short,ushort,int,uint,long,ulong,float,double>();
        }        
    }
}