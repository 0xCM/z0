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

    using static Konst;

    /// <summary>
    /// Defines an untyped literal index
    /// </summary>
    public readonly struct EnumLiterals : IConstIndex<EnumLiteralDetail>
    {
        public static EnumLiterals Empty 
            => new EnumLiterals(sys.empty<EnumLiteralDetail>());

        readonly EnumLiteralDetail[] Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiterals(EnumLiteralDetail[] src)
            => new EnumLiterals(src);
        
        [MethodImpl(Inline)]
        public EnumLiterals(EnumLiteralDetail[] src) 
            => Data = src;
        
        public EnumLiteralDetail[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
        
        public ref readonly EnumLiteralDetail this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref readonly EnumLiteralDetail this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public variant[] Values 
            => Data.Select(x => x.Value);

        public F[] Convert<F>()
            where F : unmanaged, Enum
        {
            var src = Values;
            var dst = new F[src.Length];

            for(var i=0; i< src.Length; i++)
                dst[i] = (F)(object)src[i];
            return dst;
        }

        public EnumLiterals Append(EnumLiterals more)               
            => new EnumLiterals(Data.Concat(more.Data).Array());

        public IEnumerable<NamedValue<variant>> NamedValues
            => from i in Data select NamedValue.define(i.Name, i.Value);
    }
}