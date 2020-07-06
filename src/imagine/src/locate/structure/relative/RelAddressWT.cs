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

    public readonly struct RelAddress<BW,RW,B,R>  
        where BW: unmanaged, INumericWidth 
        where RW: unmanaged, INumericWidth        
        where B: unmanaged
        where R: unmanaged
    {
        public readonly B Base;
        
        public readonly R Offset;

        NumericWidth BaseWidth 
        {
            [MethodImpl(Inline)] 
            get => Widths.numeric<BW>();
        }

        NumericWidth RelativeWidth
        {
            [MethodImpl(Inline)] 
            get => Widths.numeric<RW>();
        }

        public bool IsEmpty 
        {
             [MethodImpl(Inline)] 
             get => Offset.Equals(default);
        }

        public uint Hash
        {
            [MethodImpl(Inline)] 
            get => core.hash(Offset);
        }

        public bool IsNonEmpty  
        {
             [MethodImpl(Inline)] 
             get => !Offset.Equals(default);
        }

        public RelAddress<BW,RW,B,R> Zero 
            => default;

        [MethodImpl(Inline)]
        public static bool operator==(RelAddress<BW,RW,B,R> x, RelAddress<BW,RW,B,R> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelAddress<BW,RW,B,R> x, RelAddress<BW,RW,B,R> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public RelAddress(B @base, R offset)
        {
            Base = @base;
            Offset = offset;
        }

        public static RelAddress<BW,RW,B,R> Empty 
            => default;

        [MethodImpl(Inline)]
        public string Format()
        {
            switch(RelativeWidth)
            {
                case NumericWidth.W8:
                    return Cast.to<R,byte>(Offset).FormatSmallHex();
                case NumericWidth.W16:
                    return Cast.to<R,ushort>(Offset).FormatSmallHex();
                case NumericWidth.W32:
                    return Cast.to<R,uint>(Offset).FormatSmallHex();
                case NumericWidth.W64:
                    return Cast.to<R,ulong>(Offset).FormatSmallHex();
                default:
                    return EmptyString;
            }
        }
        

        [MethodImpl(Inline)]
        public bool Equals(RelAddress<BW,RW,B,R> src)        
            => Offset.Equals(src.Offset);
        

        public override string ToString()
            => Format();

        public override bool Equals(object src)
            => src is RelAddress x && Equals(x);

        public override int GetHashCode()
            => (int)Hash;        
    }
}