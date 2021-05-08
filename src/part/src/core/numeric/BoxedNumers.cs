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
    public readonly struct BoxedNumbers
    {
        [MethodImpl(Inline), Op]
        public static BoxedNumber define(object src, NumericKind kind)
            => new BoxedNumber(src ?? new object(), kind);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BoxedNumber define<T>(T src)
            where T : unmanaged
                => new BoxedNumber(src, Numeric.kind<T>());

        [Op]
        public static BoxedNumber convert(BoxedNumber src, NumericKind dst)
            => define(Numeric.rebox(src,dst), dst);

        [Op, Closures(AllNumeric)]
        public static T convert<T>(BoxedNumber src)
            where T : unmanaged
                => (T)typeof(T).NumericKind().Rebox(src);

        /// <summary>
        /// Puts an enum value into a (numeric) box
        /// </summary>
        /// <param name="e">The enumeration value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber from<E>(E e)
            where E : unmanaged, Enum
                => define(System.Convert.ChangeType(e, ClrEnums.ecode<E>().TypeCode()), ClrEnums.ecode<E>().NumericKind());

        [Op]
        public static BoxedNumber from(Enum e)
        {
            var tc = Type.GetTypeCode(e.GetType().GetEnumUnderlyingType());
            var nk = tc.ToNumericKind();
            var box = System.Convert.ChangeType(e,tc);
            return define(box,nk);
        }

        [Op]
        public static BoxedNumber from(object src)
        {
            if(src is null)
                return BoxedNumber.Empty;
            else if(src is Enum e)
                return from(e);

            var nk = src.GetType().NumericKind();
            if(nk != 0)
                return define(src,nk);

            return BoxedNumber.Empty;
        }
    }
}