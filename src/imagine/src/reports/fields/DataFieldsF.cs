//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   
    using static Root;

   public readonly struct DataFields<F> : IDataFields<F>
        where F : unmanaged, Enum
    {
        public F[] Literals 
        {        
            [MethodImpl(Inline)]
            get => Enums.literals<F>();
        }

        public string[] Labels 
        {        
            [MethodImpl(Inline)]
            get => Literals.Map(f => f.ToString());
        }

        [MethodImpl(Inline)]
        public short Index(F f)
            => (short)scalar<F,int>(f);

        [MethodImpl(Inline)]
        public short Width(F f)
            => (short)(scalar<F,int>(f) >> 16);

        public int Length
        {
            [MethodImpl(Inline)]
            get => Literals.Length;
        }
        
        public ref readonly F this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Literals[index];
        }
    }
}