//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Text;

    using static zfunc;

    partial class xfunc
    {

        /// <summary>
        /// Returns true if not blank
        /// </summary>
        /// <param name="s">The string to evaluate</param>
        [MethodImpl(Inline)]
        static bool HasValue(string s)
            => !string.IsNullOrWhiteSpace(s);

        static bool HasContent(this (string content, string remainder) value)
            => HasValue(value.content);

        static bool HasRemainder(this (string content, string remainder) value)
            => HasValue(value.remainder);

        static bool HasBoundedContent(this string text, (char l, char r) boundary)
        {
            var l = text.IndexOf(boundary.l);
            var r = text.LastIndexOf(boundary.r);
            return r - l > 0;
        }

        static bool HasBoundedContent(this string text, (string l, string r) boundary)
        {
            var l = text.IndexOf(boundary.l);
            var r = text.LastIndexOf(boundary.r);
            return r - l > 0;
        }

        static (string content, string remainder) Next(this string s, (char l, char r) boundary)
        {
            if (!s.HasBoundedContent(boundary))
                return (string.Empty, string.Empty);

            var content = string.Empty;
            var match = 1;
            var idx = 0;
            for (var i = s.IndexOf(boundary.l) + 1; i < s.Length; i++)
            {
                idx = i;
                var c = s[i];
                if (c == boundary.l)
                    match++;
                else if (c == boundary.r)
                    match--;

                if (match == 0)
                    break;
                else
                    content += s[i];
            }
            return (content, s.Substring(idx + 1));
        }

        static IEnumerable<string> Drill(this string text, (char l, char r) boundary)
        {
            var current = text;
            while (current.HasBoundedContent(boundary))
            {
                var drill = Next(current, boundary);
                if (drill.HasContent())
                {
                    var drilled = drill.content;
                    yield return drilled;

                    if (drilled.HasBoundedContent(boundary))
                        foreach (var content in drilled.GetBoundedContent(boundary))
                            if (HasValue(content))
                                yield return content;

                    current = drill.remainder;
                }
            }
        }

        /// <summary>
        /// Extracts text segments that are demarcated by left/right charcter boundaries
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="l">The left boundary</param>
        /// <param name="r">The right boundary</param>
        public static IEnumerable<string> GetBoundedContent(this string s, char l, char r)
            => s.GetBoundedContent((l, r));

        /// <summary>
        /// Extracts text segments that are demarcated by left/right charcter boundaries
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="boundary">The boundary characters</param>
        public static IEnumerable<string> GetBoundedContent(this string s, (char l, char r) boundary)
        {
            var next = Next(s, boundary);

            if (next.HasContent())
            {
                yield return next.content;

                foreach (var drilled in next.remainder.Drill(boundary))
                    yield return drilled;

                foreach (var content in next.content.GetBoundedContent(boundary))
                {
                    if (HasValue(content))
                        yield return content;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="Match"/> obtained via a regular expression contains a specified group
        /// </summary>
        /// <param name="m">The match</param>
        /// <param name="name">The candidate group name</param>
        public static bool HasGroupValue(this Match m, string name)
            => m.Groups[name].Success;

        /// <summary>
        /// Gets the value of a named match group if it exists; otherwise, throws an exception
        /// </summary>
        /// <param name="m">The matched expression</param>
        /// <param name="name">The name of the group</param>
        public static string GetGroupValue(this Match m, string name)
        {
            if (!m.Groups[name].Success)
                throw new ArgumentException($"The group {name} was not matched successfully");

            return m.Groups[name].Value;
        }

        public static Option<string> TryGetGroupValue(this Regex x, string input, string group)
        {
            var match = x.Match(input);
            if (match.Success && match.Groups[group].Success)
                return match.Groups[group].Value;
            else
                return none<string>();
        }

        /// <summary>
        /// Gets the value of an identified regular expression group
        /// </summary>
        /// <typeparam name="T">The group value type</typeparam>
        /// <param name="m">The matched expression</param>
        /// <param name="name">The name of the group</param>
        public static T GetGroupValue<T>(this Match m, string name)
        {
            var result = default(object);

            var groupValue = m.GetGroupValue(name);
            var valueType = typeof(T);
            if (valueType == typeof(string))
                result = groupValue;
            else if (valueType.IsNullableType())
                result = System.Convert.ChangeType(groupValue, Nullable.GetUnderlyingType(valueType));
            else
                result = System.Convert.ChangeType(groupValue, valueType);
            return (T)result;
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

        public static StringBuilder WithLabeled(this StringBuilder sb, object label, object content, int? labelWidth = null)
        {
            var padR = labelWidth ?? 12;
            sb.Append($"{label}".PadRight(padR));
            sb.Append($"{content}");
            sb.AppendLine();
            return sb;
        }

        public static StringBuilder AppendLine(this StringBuilder sb, char c)
        {
            sb.AppendLine(c.ToString());
            return sb;
        }

        public static string Format(this Utf8AsciPoint src)
        {
            var bits = src.Code.FormatBits();
            var num = src.Code.FormatHex();
            var str = src.IsControl ? "___"  : $"'{src.ToChar()}'";
            return $"{num} {bits} {str}";
        }        
    }
}