//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Indexes default set of primitive parsers
    /// </summary>
    static IDictionary<Type, Func<string, object>> parsers = new Dictionary<Type, Func<string, object>>
    {
        [typeof(Date)] = s => Date.Parse(s),

        [typeof(Date?)] = s => TryParseDate(s),

        [typeof(DateTime)] = s => DateTime.Parse(s),

        [typeof(DateTime?)] = s => TryParseDateTime(s),

        [typeof(Guid)] = s => Guid.Parse(s),

        [typeof(Guid?)] = s => TryParseGuid(s),

        [typeof(decimal)] = s => decimal.Parse(s, NumberStyleOptions, CultureInfo.InvariantCulture),

        [typeof(decimal?)] = s => TryParseDecimal(s),

        [typeof(TimeSpan)] = s => TimeSpan.Parse(s),

        [typeof(TimeSpan?)] = s => TryParseTimeSpan(s),

        [typeof(bool)] = s => ParseBool(s),

        [typeof(bool?)] = s => text.empty(s) ? null : (bool?)ParseBool(s),

        [typeof(int)] = s => int.Parse(s),

        [typeof(int?)] = s => TryParseInt32(s),

        [typeof(short)] = s => short.Parse(s),

        [typeof(short?)] = s => TryParseInt16(s),

        [typeof(long)] = s => long.Parse(s),

        [typeof(long?)] = s => TryParseInt64(s),

        [typeof(double)] = s => double.Parse(s),

        [typeof(double?)] = s => TryParseDouble(s),

        [typeof(string)] = s => s
    };

    static readonly NumberStyles NumberStyleOptions =
        NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign |
        NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands;

    static readonly HashSet<string> TrueValues
        = new HashSet<string>(new[] { "true", "t", "1", "y", "+" });

    static readonly HashSet<string> FalseValues
        = new HashSet<string>(new[] { "false", "f", "0", "n", "-" });


    /// <summary>
    /// Attempts to parse the supplied value
    /// </summary>
    public static object parse(Type t, string s)
        => parsers[t](s);

    /// <summary>
    /// Evaluates a function over a value if the value is not null; otherwise invokes
    /// a function that will produce a value that is within the expected range
    /// </summary>
    /// <typeparam name="S">The object type</typeparam>
    /// <typeparam name="T">The function result type</typeparam>
    /// <param name="x">The object to test</param>
    /// <param name="f1">The non-null evaluator</param>
    /// <param name="f2">The null evaluator</param>
    [MethodImpl(Inline)]
    static T ifvalue<S, T>(S x, Func<S, T> f1, Func<T> f2)
        where S : class => (x != null) ? f1(x) : f2();
 
    /// <summary>
    /// Attempts to parse the supplied value
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="s">The value to parse</param>
    static Option<T> tryParse<T>(string s, Action<Exception> error = null)
    {
        try
        {
            return ifvalue(s, _ => (T)parsers[typeof(T)](s), () => Option.none<T>());
        }
        catch (Exception e)
        {
            error?.Invoke(e);
            return Option.none<T>();
        }
    }
    
 

    /// <summary>
    /// Helper to parse a boolean value in a more reasonable fashion than the intrinsic <see cref="bool.Parse(string)"/> method
    /// </summary>
    /// <param name="src">The text to parse</param>
    static bool ParseBool(string src)
    {
        var key = src.ToLower();
        if (TrueValues.Contains(key))
            return true;
        else if (FalseValues.Contains(key))
            return false;
        else
            throw new ArgumentException($"Could not interpret {src} as a boolean value");
    }

    /// <summary>
    /// Parses an <see cref="Int32"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    static int? TryParseInt32(string src)
    {
        if (Int32.TryParse(src, out int result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses an <see cref="Int64"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    static long? TryParseInt64(string src)
    {
        if (Int64.TryParse(src, out long result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Byte"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static byte? TryParseUInt8(string src)
    {
        var result = (byte)0;
        if (Byte.TryParse(src, out result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Date"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static Date? TryParseDate(string src)
    {
        if (Date.TryParse(src, out Date result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="DateTime"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static DateTime? TryParseDateTime(string src)
    {
        if (DateTime.TryParse(src, out DateTime result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Guid"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="src">The text to parse</param>
    /// <returns></returns>
    static Guid? TryParseGuid(string src)
    {
        if (Guid.TryParse(src, out Guid result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses an <see cref="Int16"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    /// <returns></returns>
    static Int16? TryParseInt16(string s)
    {
        if (Int16.TryParse(s, out Int16 result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="Double"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    static double? TryParseDouble(string s)
    {
        if (double.TryParse(s, out double result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="TimeSpan"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    static TimeSpan? TryParseTimeSpan(string s)
    {
        if (TimeSpan.TryParse(s, out TimeSpan result))
            return result;
        else
            return null;
    }

    /// <summary>
    /// Parses a <see cref="decimal"/> value if possible, otherwise returns null
    /// </summary>
    /// <param name="s">The text to parse</param>
    static decimal? TryParseDecimal(string s)
    {
        if (decimal.TryParse(s, NumberStyleOptions, CultureInfo.InvariantCulture, out decimal result))
            return result;
        else
            return null;
    }
}