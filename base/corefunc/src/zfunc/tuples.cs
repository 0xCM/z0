//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Defines an homogenous pair
    /// </summary>
    /// <param name="a">The first member</param>
    /// <param name="b">The second member</param>
    /// <typeparam name="T">The member type</typeparam>
    [MethodImpl(Inline)]
    public static Pair<T> pair<T>(T a, T b)
        where T : unmanaged
            => Tuples.pair<T>(a,b);

    /// <summary>
    /// Defines an homogenous triple
    /// </summary>
    /// <param name="a">The first member</param>
    /// <param name="b">The second member</param>
    /// <param name="c">The third member</param>
    /// <typeparam name="T">The member type</typeparam>
    [MethodImpl(Inline)]
    public static Triple<T> triple<T>(T a, T b, T c)
        where T : unmanaged
            => Tuples.triple<T>(a,b,c);

    /// <summary>
    /// Defines a non-homogenous pair
    /// </summary>
    /// <param name="a">The first member</param>
    /// <param name="b">The second member</param>
    /// <typeparam name="T0">The first member type</typeparam>
    /// <typeparam name="T1">The second member type</typeparam>
    [MethodImpl(Inline)]
    public static Pair<T0,T1> paired<T0,T1>(T0 a, T1 b)
        where T0 : unmanaged
        where T1 : unmanaged
            => Tuples.pair(a,b);

    /// <summary>
    /// Defines a non-homogenous triple
    /// </summary>
    /// <param name="a">The first member</param>
    /// <param name="b">The second member</param>
    /// <param name="c">The third member</param>
    /// <typeparam name="X">The type of the first member</typeparam>
    /// <typeparam name="Y">The type of the second member</typeparam>
    /// <typeparam name="Z">The type of the third member</typeparam>
    [MethodImpl(Inline)]
    public static Triple<X,Y,Z> tripled<X,Y,Z>(X a, Y b, Z c)
        where X: unmanaged
        where Y : unmanaged
        where Z : unmanaged
            => Tuples.triple(a,b,c);

    /// <summary>
    /// Maps a function over a 2-tuple
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X">The projected type</typeparam>
    /// <param name="x">The input value</param>
    /// <param name="f">The function to apply</param>
    [MethodImpl(Inline)]
    public static X map<X1, X2, X>((X1 x1, X2 x2) x, Func<X1, X2, X> f)
        => f(x.x1, x.x2);

    /// <summary>
    /// Maps two functions over respective over respective 2-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2) map<X1, X2, Y1, Y2>((X1 x1, X2 x2) x, Func<X1, Y1> f1, Func<X2, Y2> f2)
        => (f1(x.x1), f2(x.x2));

    /// <summary>
    /// Maps a function over a 3-tuple
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X">The projected type</typeparam>
    /// <param name="x">The input value</param>
    /// <param name="f">The function to apply</param>
    [MethodImpl(Inline)]
    public static X map<X1, X2, X3, X>((X1 x1, X2 x2, X3 x3) x, Func<X1, X2, X3, X> f)
        => f(x.x1, x.x2, x.x3);

    /// <summary>
    /// Determines the tuple's style, if possible; otherwise, returns None
    /// </summary>
    /// <param name="text">The putative tuple representation</param>
    /// <returns></returns>
    static Option<TupleFormat> style(string text)
        => text.EnclosedBy(lparen(), rparen()) ? some(TupleFormat.Coordinate)
        : text.EnclosedBy(lbracket(), rbracket()) ? some(TupleFormat.List)
        : text.EnclosedBy(lbrace(), rbrace()) ? some(TupleFormat.Record)
        : none<TupleFormat>();

    static char leftBound(TupleFormat style)
        => (style == TupleFormat.Coordinate ? lparen()
        : style == TupleFormat.List ? lbracket()
        : style == TupleFormat.Record ? lbrace()
        : lparen())[0];

    static char rightBound(TupleFormat style)
        => (style == TupleFormat.Coordinate ? rparen()
        : style == TupleFormat.List ? rbracket()
        : style == TupleFormat.Record ? rbrace()
        : rparen())[0];

    static char[] bounds(TupleFormat style)
        => zfunc. array(leftBound(style), rightBound(style));

    /// <summary>
    /// Gets the boundary production function as determined by a style
    /// </summary>
    /// <param name="style">The tuple representation style</param>
    internal static Func<string, string> boundaryFn(TupleFormat style)
        => style == TupleFormat.List ? new Func<string, string>(bracket)
        : style == TupleFormat.Record ? new Func<string, string>(embrace)
        : new Func<string, string>(x => parenthetical(x));

    /// <summary>
    /// Parses a tuple of the form (x1,x2)
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    public static Option<(X1 x1, X2 x2)> parsetuple<X1, X2>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 3
           from x1 in tryParse<X1>(components[0])
           from x2 in tryParse<X2>(components[1])
           select (x1, x2);

    /// <summary>
    /// Parses a tuple in when represented in canonical form (x1,x2,x3)
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    public static Option<(X1 x1, X2 x2, X3 x3)> parsetuple<X1, X2, X3>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 3
           from x1 in tryParse<X1>(components[0])
           from x2 in tryParse<X2>(components[1])
           from x3 in tryParse<X3>(components[2])
           select (x1, x2, x3);

    /// <summary>
    /// Parses a tuple of the form (x1,x2,x3,x4)
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    public static Option<(X1 x1, X2 x2, X3 x3, X4 x4)> parsetuple<X1, X2, X3, X4>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 4
           from x1 in tryParse<X1>(components[0])
           from x2 in tryParse<X2>(components[1])
           from x3 in tryParse<X3>(components[2])
           from x4 in tryParse<X4>(components[3])
           select (x1, x2, x3, x4);

    /// <summary>
    /// Parses a tuple in when represented in canonical form
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    public static Option<(X1 x1, X2 x2, X3 x3, X4 x4, X5 x5)> parsetuple<X1, X2, X3, X4, X5>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 5           
           from x1 in tryParse<X1>(components[0])
           from x2 in tryParse<X2>(components[1])
           from x3 in tryParse<X3>(components[2])
           from x4 in tryParse<X4>(components[3])
           from x5 in tryParse<X5>(components[4])
           select (x1, x2, x3, x4, x5);

    /// <summary>
    /// Parses a tuple in when represented in canonical form
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    public static Option<(X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6)> parsetuple<X1, X2, X3, X4, X5, X6>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 5
           from x1 in tryParse<X1>(components[0])
           from x2 in tryParse<X2>(components[1])
           from x3 in tryParse<X3>(components[2])
           from x4 in tryParse<X4>(components[3])
           from x5 in tryParse<X5>(components[4])
           from x6 in tryParse<X6>(components[5])
           select (x1, x2, x3, x4, x5, x6);
}