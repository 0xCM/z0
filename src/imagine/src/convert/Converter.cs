//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    readonly struct BoxedNumberConverter : IConversionProvider<BoxedNumberConverter,BoxedNumber>, IBiconverter<BoxedNumber>
    {
        public BoxedNumberConverter Converter 
            => default;
        
        /// <summary>
        /// Pulls a number of kind parametric from a box - whose kind it matters not
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target numeric type</typeparam>
        [MethodImpl(Inline)]
        public T Convert<T>(BoxedNumber src) 
            => (T)z.rebox(src.Boxed, NumericKinds.kind<T>());

        /// <summary>
        /// Puts a number in a box of kind parametric
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public BoxedNumber Convert<T>(T src) 
            => BoxedNumber.Define(src, NumericKinds.kind<T>());

        public Option<object> ConvertFromTarget(object incoming, Type dst)
        {
            try
            {
                var src = (BoxedNumber)incoming;
                return rebox(src.Boxed, dst.NumericKind());
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        public Option<object> ConvertToTarget(object incoming)
        {
            var kind = (incoming?.GetType() ?? typeof(void)).NumericKind();
            return kind.IsSome() ? BoxedNumber.Define(incoming, kind) : Option.none<BoxedNumber>();
        }
    }
}