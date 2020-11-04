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

    [ApiHost]
    public readonly struct SurveyFormatter
    {
        const NumericKind Closure = UnsignedInts;

        [Op, Closures(Closure)]
        public static string format<T>(in SurveyResponse<T> src)
            where T : unmanaged
        {
            var dst = text.build();

            for(var i=0; i<src.Answered.Length; i++)
            {
                dst.Append(src.Answered[i].QuestionId);
                dst.Append(Chars.Colon);
                dst.Append(Chars.Space);
                dst.Append(src.Answered[i].Format());
                dst.AppendLine();
            }

            return dst.ToString();
        }

        [Op, Closures(Closure)]
        public static string format<T>(in Question<T> src)
            where T : unmanaged
        {
            var dst = text.build();
            dst.Append(src.Label.PadRight(12));
            dst.Append(Chars.Colon);
            dst.Append(Chars.Space);
            dst.Append(Chars.LBracket);
            dst.Append(string.Join(src.MultipleChoice ? Chars.Pipe : Chars.Caret, src.Choices.Select(c => c.Format())));
            dst.Append(Chars.RBracket);
            return dst.ToString();
        }

        [Op, Closures(Closure)]
        public static string format<T>(in Survey<T> src)
            where T : unmanaged
        {
            var format = text.build();
            format.AppendLine(src.Name);
            format.AppendLine(new string(Chars.Dash,80));
            for(var i=0; i<src.Questions.Length; i++)
                format.AppendLine(SurveyFormatter.format(src.Questions[i]));
                    return format.ToString();
        }

        [Op, Closures(Closure)]
        public static string format<T>(in QuestionChoice<T> src)
            where T : unmanaged
                => text.parenthetical(src.Title);

        [Op, Closures(Closure)]
        public static string title<T>(T id, string label)
            where T : unmanaged
        {
            const string Pattern = "{0}: {1}";
            return string.Format(Pattern, log2(id), label);
        }

        [MethodImpl(Inline)]
        static T log2<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Pow2.log2(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Pow2.log2(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Pow2.log2(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Pow2.log2(uint64(a)));
            else
                throw no<T>();
        }

        [Op]
        public static string label(uint index)
        {
            var q = (int)(index / 26);
            var r = (int)(index % 26);
            var code = Convert.ToChar(ChoiceCodes[r]);
            var label = ChoiceCodes[r].ToString();
            if(q != 0)
                label = new string(code,q);
            else
                label = code.ToString();
            return label;
        }

        /// <summary>
        /// The numeric codes for the asci characters 'A' .. 'Z'
        /// </summary>
        static ReadOnlySpan<byte> ChoiceCodes
            => new byte[26]{65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90};
    }
}