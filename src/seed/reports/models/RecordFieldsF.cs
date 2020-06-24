//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   
    using static RecordFields;

   public readonly struct RecordFields<F> : IRecordFields<F>
        where F : unmanaged, Enum
    {
        public F[] Literals 
        {        
            [MethodImpl(Inline)]
            get => Service.Literals<F>();
        }

        public string[] Labels 
        {        
            [MethodImpl(Inline)]
            get => Service.Labels<F>();
        }

        [MethodImpl(Inline)]
        public short Index(F f)
            => Service.Index(f);

        [MethodImpl(Inline)]
        public short Width(F f)
            => Service.Width(f);

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