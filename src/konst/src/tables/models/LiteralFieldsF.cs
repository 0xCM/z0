//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct LiteralFields<F>
        where F : unmanaged, Enum
    {
        public readonly FieldInfo[] Definitions;

        public readonly F[] Values;

        [MethodImpl(Inline)]
        public static implicit operator LiteralFields<F>(FieldInfo[] src)
            => new LiteralFields<F>(src);

        [MethodImpl(Inline)]
        public LiteralFields(FieldInfo[] src)
        {
            Definitions = src;
            Values = src.Map(f => (F)f.GetRawConstantValue());
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Definitions.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Definitions.Length;
        }

        public ReadOnlySpan<FieldInfo> View
        {
            [MethodImpl(Inline)]
            get => Definitions;
        }

        public Span<FieldInfo> Edit
        {
            [MethodImpl(Inline)]
            get => Definitions;
        }

        [MethodImpl(Inline)]
        public string Name(uint index)
            => Definitions[index].Name;
        
        public ref readonly F this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Values[index];
        }        

        [MethodImpl(Inline)]
        public ref readonly FieldInfo Definition(uint index)
            => ref Definitions[index];

        
        [MethodImpl(Inline)]
        public RenderWidth Width(F f)   
            => z.@as<F,byte>(f);
    }
}