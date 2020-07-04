//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;

    using static Konst;

    /// <summary>
    /// Defines an untyped literal index
    /// </summary>
    public readonly struct EnumLiterals : IConstIndex<EnumLiteral>
    {
        readonly EnumLiteral[] Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiterals(EnumLiteral[] src)
            => new EnumLiterals(src);
        
        [MethodImpl(Inline)]
        internal EnumLiterals(EnumLiteral[] src) 
            => Data = src;

        public EnumLiteral[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
        
        public ref readonly EnumLiteral this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }
        
        public variant[] Values 
            => Data.Map(x => Enums.scalar(x.LiteralValue));

        public F[] Convert<F>()
            where F : unmanaged, Enum
        {
            var src = Values;
            var dst = new F[src.Length];

            for(var i=0; i< src.Length; i++)
                dst[i] = (F)(object)src[i];
            return dst;
        }
                
        public IEnumerable<NamedValue<Enum>> NamedValues
            => from i in Data select NamedValue.define(i.Identifier, i.LiteralValue);
    }
}