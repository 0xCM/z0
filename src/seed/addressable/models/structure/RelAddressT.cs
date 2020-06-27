//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericCast;

    public readonly struct RelAddress<T> : INullary<RelAddress<T>>, ITextual, INullity
        where T : unmanaged         
    {
        readonly T Offset;

        NumericWidth Size 
        {
            [MethodImpl(Inline)] 
            get => Root.bitsize<T>();
        }

        public bool IsEmpty 
        {
             [MethodImpl(Inline)] 
             get => Offset.Equals(default);
        }

        public bool IsNonEmpty  
        {
             [MethodImpl(Inline)] 
             get => !Offset.Equals(default);
        }

        public RelAddress<T> Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static RelAddress<T> From(T offset)
            => new RelAddress<T>(offset);

        [MethodImpl(Inline)]
        public static bool operator==(RelAddress<T> x, RelAddress<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelAddress<T> x, RelAddress<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        RelAddress(T offset)
        {
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            switch(Size)
            {
                case NumericWidth.W8:
                    return convert<T,byte>(Offset).FormatSmallHex();
                case NumericWidth.W16:
                    return convert<T,ushort>(Offset).FormatSmallHex();
                default:
                    return convert<T,uint>(Offset).FormatAsmHex();
            }
        }
        
        public bool Equals(RelAddress<T> src)        
            => Offset.Equals(src.Offset);

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Offset.GetHashCode();
        
        public override bool Equals(object src)
            => src is RelAddress l && Equals(l);

        public static RelAddress<T> Empty 
            => default;
    }
}