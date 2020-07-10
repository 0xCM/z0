//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using NK = NumericKind;
    using DW = DataWidth;

    [ApiHost]
    public readonly partial struct Part
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
                
        public const string EmpyString = "";

        /// <summary>
        /// The number of bits to shift a field specifier left/right to reveal/specify the width of an identified field
        /// </summary>
        public const int WidthOffset = 16;        

        /// <summary>
        /// Specifies the widths of system-supported primal numeric data types
        /// </summary>
        public const DW NumericWidths = DW.W8 | DW.W16 | DW.W32 | DW.W64;

        /// <summary>
        /// Specifies unsigned integral types of widths <see cref='NumericWidths'/>
        /// </summary>
         public const NK UnsignedInts = NK.UnsignedInts;

        /// <summary>
        /// Specifies signed integral types of widths <see cref='NumericWidths'/>
        /// </summary>
        public const NK SignedInts = NK.SignedInts;

        /// <summary>
        /// Specifies signed and unsigned integral types of widths <see cref='NumericWidths'/>
        /// </summary>
        public const NK Integers = NK.Integers;

        public const NK AllNumeric = NK.All;

        [MethodImpl(Inline), Op]
        public static PartId withoutTest(PartId a)
            => a & ~ PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withTest(PartId a)
            => a | PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withoutSvc(PartId a)
            => a & ~ PartId.Svc;

        [MethodImpl(Inline), Op]
        public static PartId withSvc(PartId a)
            => a | PartId.Svc;

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        internal static T[] map<S,T>(IEnumerable<S> src, Func<S,T> f)
        {
            Span<S> source = src.ToArray();
            var count = source.Length;
            var buffer = new T[count];
            Span<T> target = buffer;
            for(var i=0; i<count; i++)
                target[i] = f(source[i]);
            return buffer;
        }

        /// <summary>
        /// Allocates and populates a new array by filtering the source array with a specified predicate 
        /// </summary>
        /// <param name="src">The soruce array</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline)]
        internal static T[] where<T>(ReadOnlySpan<T> src, Func<T,bool> f)
        {
            var length = src.Length;
            Span<T> dst = new T[length];
            var count = 0;
            for(var i=0; i<length; i++)
            {
                ref readonly var test = ref src[i];
                if(f(test))
                    dst[count++] = test;                    
            }   
            return dst.Slice(0, (int)count).ToArray();
        }        


    }
    
    public static partial class XTend
    {
        
    }
}