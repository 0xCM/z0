//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexText
    {        
        public readonly StringRef Ref;

        [MethodImpl(Inline)]
        public HexText(StringRef src)
        {
            Ref = src;
        }

        public string Text
        {
            [MethodImpl(Inline)]
            get => Ref.Text;
        }
    }

    public readonly struct HexText<K>
        where K : unmanaged, Enum
    {        
        public readonly StringRef Ref;

        [MethodImpl(Inline)]
        public HexText(StringRef src)
        {
            Ref = src;
        }

        public string Text
        {
            [MethodImpl(Inline)]
            get => Ref.Text;
        }

        // public string this[int index]
        // {
        //     [MethodImpl(Inline)]
        //     get => Ref.Advance((uint)index).Text;
        // }
        
        public static HexText<K> Empty 
            => new HexText<K>(StringRef.Empty);
    }
}