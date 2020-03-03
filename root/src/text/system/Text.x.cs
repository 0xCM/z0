//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    public static partial class TextExtensions
    {
        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
        [MethodImpl(Inline)]   
        static Y apply<X,Y>(X x,Func<X,Y> f)
            => f(x);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        static bool nonempty(string src)
            => !String.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        static bool empty(string src)
            => String.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Searches for the last index of a specified character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        public static Option<int> LastIndexOf(this string s, char c)
        {
            var idx = s.LastIndexOf(c);
            return idx != -1 ? some(idx) : none<int>();
        }

        /// <summary>
        /// Searches a string for the first occurrence of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The marking character</param>
        public static Option<int> FirstIndexOf(this string s, char c)
        {
            var idx = s.IndexOf(c);
            return idx != -1 ? some(idx) : none<int>();
        }

        /// <summary>
        /// Removes whitespace characters from a string
        /// </summary>
        /// <param name="src">The source string</param>
        public static string RemoveWhitespace(this string src)
            => src.RemoveAny(items(AsciSym.Space, AsciEscape.LineFeed, AsciEscape.NewLine, AsciEscape.Tab));

        public static string Bracket(this string src)
            => $"[{src}]";


        /// <summary>
        /// Formats the supplied decimal value as currency to two decimal places
        /// </summary>
        /// <param name="d">The decimal value</param>
        public static string FormatAsCurrency(this decimal src, int scale = 2)
            => String.Format(text.embrace($"0:C{scale}"), src);

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this short src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this ushort src)
                => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this int src)
                => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this uint src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this long src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this ulong src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this float src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this double src)
            => src.ToString("#,#");

        public static char ToDecimalChar(this byte src)
        {
            if(src == 0)
                return '0';
            else if(src == 1)
                return '1';
            else if(src == 2)
                return '2';
            else if(src == 3)
                return '3';
            else if(src == 4)
                return '4';
            else if(src == 5)
                return '5';
            else if(src == 6)
                return '6';
            else if(src == 7)
                return '7';
            else if(src == 8)
                return '8';
            else if(src == 9)
                return '9';
            else
                return '∅';                        
        }            

        /// <summary>
        /// Creates a span of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Replicate(this char src, int count)
            => text.replicate(src,count);

        /// <summary>
        /// Determines whether the source character is a decimal digit per the unicode standard
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static bool IsDecimalDigit(this char c)
            => char.IsDigit(c);

        /// <summary>
        /// Determines whether the source character is a binary digit, i.e. either '0' or '1'
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static bool IsBinaryDigit(this char c)
            => c == '0' || c == '1';

        /// <summary>
        /// Block-formats a string using specified block length and separator
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="blocklen">The number of characters in each block, save the last</param>
        /// <param name="sep">The block separator</param>
        [MethodImpl(Inline)]
        public static string SeparateBlocks(this string src, int blocklen, string sep)
            => src.Partition(blocklen).Concat(sep);

        /// <summary>
        /// Block-formats a string using specified block length and separator
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="blocklen">The number of characters in each block, save the last</param>
        /// <param name="sep">The block separator</param>
        [MethodImpl(Inline)]
        public static string SeparateBlocks(this string src, int blocklen, char sep)
            => src.Partition(blocklen).Concat(sep.ToString());

        /// <summary>
        /// Block-formats a string using specified block length, separator and block prefix
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="blocklen">The number of characters in each block, save the last</param>
        /// <param name="sep">The block separator</param>
        /// <param name="prefix">Content that immediately precedes each block</param>
        [MethodImpl(Inline)]
        public static string SeparateBlocks(this string src, int blocklen, char sep, string blockprefix)
        {
            var parts = src.Partition(blocklen).ToArray();            
            var result = text.factory.Builder();
            var prefix = blockprefix ?? string.Empty;
            var lastindex = parts.Length - 1;
            for(var i=0; i<parts.Length; i++)
            {
                result.Append(prefix);
                result.Append(parts[i]);
                if(i != lastindex)
                    result.Append(sep);
            }
            return result.ToString();
        }    

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool ContentEqual(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)        
             => lhs.CompareTo(rhs, StringComparison.InvariantCulture) == 0;

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool ContentEqual(this Span<char> lhs, ReadOnlySpan<char> rhs)        
             => lhs.ReadOnly().ContentEqual(rhs);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool ContentEqual(this Span<char> lhs, Span<char> rhs)        
             => lhs.ReadOnly().ContentEqual(rhs);

    }
}