//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Determines the tuple's style, if possible; otherwise, returns None
    /// </summary>
    /// <param name="src">The putative tuple representation</param>
    static Option<TupleFormat> style(string src)
        => src.EnclosedBy(text.lparen(), text.rparen()) ? Option.some(TupleFormat.Coordinate)
        : src.EnclosedBy(text.lbracket(), text.rbracket()) ? Option.some(TupleFormat.List)
        : src.EnclosedBy(text.lbrace(), text.rbrace()) ? Option.some(TupleFormat.Record)
        : Option.none<TupleFormat>();

    static char leftBound(TupleFormat style)
        => (style == TupleFormat.Coordinate ? text.lparen()
        : style == TupleFormat.List ? text.lbracket().ToString()
        : style == TupleFormat.Record ? text.lbrace()
        : text.lparen())[0];

    static char rightBound(TupleFormat style)
        => (style == TupleFormat.Coordinate ? text.rparen()
        : style == TupleFormat.List ? text.rbracket().ToString()
        : style == TupleFormat.Record ? text.rbrace()
        : text.rparen())[0];

    static char[] bounds(TupleFormat style)
        => Root.array(leftBound(style), rightBound(style));

    /// <summary>
    /// Gets the boundary production function as determined by a style
    /// </summary>
    /// <param name="style">The tuple representation style</param>
    static Func<string, string> boundaryFn(TupleFormat style)
        => style == TupleFormat.List ? new Func<string, string>(text.bracket)
        : style == TupleFormat.Record ? new Func<string, string>(text.embrace)
        : new Func<string, string>(x => text.parenthetical(x));

    /// <summary>
    /// Parses a tuple of the form (x1,x2)
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    static Option<(X1 x1, X2 x2)> parsetuple<X1, X2>(string text)
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
    static Option<(X1 x1, X2 x2, X3 x3)> parsetuple<X1, X2, X3>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 3
           from x1 in tryParse<X1>(components[0])
           from x2 in tryParse<X2>(components[1])
           from x3 in tryParse<X3>(components[2])
           select (x1, x2, x3);
}