//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;

    [ApiHost]
    public static class BoxOps
    {
        [MethodImpl(Inline),Op,NumericClosures(NumericKind.All)]
        public static BoxedNumber number<T>(T src)
            where T : unmanaged
                => new BoxedNumber(src);

        [MethodImpl(Inline),Op]
        public static BoxedNumber from(object src)
            => new BoxedNumber(src);

        [MethodImpl(Inline),Op,NumericClosures(NumericKind.All)]
        public static T unbox<T>(BoxedNumber src)
            where T : unmanaged
                => (T)src.Value;            

        [MethodImpl(Inline),Op]
        public static BoxedNumber convert(BoxedNumber src, NumericKind dst)
            => BoxOps.from(dst.Convert(src.Value));

        [MethodImpl(Inline),Op]
        public static BoxedNumber convert(BoxedNumber src, Type target)
            => from(target.NumericKind().Convert(src.Value));

        [MethodImpl(Inline),Op,NumericClosures(NumericKind.All)]
        public static T convert<T>(BoxedNumber src)
            where T : unmanaged
                => unbox<T>(convert(src,typeof(T)));

        [MethodImpl(Inline),Op]
        public static FixedWidth width(BoxedNumber src)
            => src.Value.GetType().NumericKind().WidthKind();
        
        [MethodImpl(Inline),Op]
        public static bool eq(BoxedNumber lhs, BoxedNumber rhs)
        {
            if(lhs.IsSignedInt && rhs.IsSignedInt)
                return lhs.Convert<long>() == rhs.Convert<long>();
            else if(lhs.IsUnsignedInt && rhs.IsUnsignedInt)
                return lhs.Convert<ulong>() == rhs.Convert<ulong>();
            else if(lhs.IsFloat && rhs.IsFloat)
                return lhs.Convert<double>() == rhs.Convert<double>();
            else   
                return false;
        }
    }
}
