//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Textual)]

namespace Z0.Parts
{        
    public sealed class Textual : Part<Textual>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class Textual
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
        [MethodImpl(Inline)]   
        internal static Y apply<X,Y>(X x,Func<X,Y> f)
            => f(x);

        [MethodImpl(Inline)]
        internal static T? unvalued<T>()
            where T : struct
                => (T?)null;
    }

    public static partial class XText    
    {
        internal static StringBuilder builder()
            => new StringBuilder();
    }

    public static partial class XTend
    {

    }
}
