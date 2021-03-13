//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    partial struct ApiIdentity
    {
        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline), Op]
        public static OpIdentity numeric(string opname, NumericKind k, bool generic = false)
            => build(opname, TypeWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static TypeIdentity numeric<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.numeric(t);

        [MethodImpl(Inline), Op]
        public static TypeIdentity numeric(string prefix, Type arg)
            => TypeIdentity.numeric(prefix,arg);


        /// <summary>
        /// Attempts to parse a numeric kind from a string in the form {width}{indicator}
        /// </summary>
        /// <param name="src">The source text</param>
        [Op]
        public static NumericKind numeric(string src)
        {
            var input = src.Trim();
            if(string.IsNullOrWhiteSpace(input))
                return 0;

            var indicator = (NumericIndicator)input.Last();
            if(!indicator.IsLiteral() || indicator == NumericIndicator.None)
                return 0;

            var width = 0u;
            if(!uint.TryParse(input.Substring(0, input.Length - 1), out width))
                return 0;

            var nw = (NumericWidth)width;
            if(!nw.IsLiteral())
                return 0;

            var kind = nw.ToNumericKind(indicator);
            if(!kind.IsLiteral())
                return 0;

            return kind;
        }

        /// <summary>
        /// Attempts to parse a sequence of numeric kinds from a sequence of strings in the form {width}{indicator}
        /// </summary>
        /// <param name="src">The source text</param>
        public static IEnumerable<NumericKind> numeric(IEnumerable<string> kinds)
            => from part in kinds
               let x = part.StartsWith(IDI.GenericLocator)
                    ? numeric(part.Substring(1, part.Length - 1))
                    : numeric(part)
                select x;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NumericKind nk<T>()
            => Numeric.kind<T>();

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]
        public static OpIdentity NumericOp(string opname, NumericKind k, bool generic = false)
            => build(opname, TypeWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static OpIdentity NumericOp<T>(string opname, bool generic = true)
            where T : unmanaged
                => build(opname, TypeWidth.None, nk<T>(), generic);
    }
}