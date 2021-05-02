//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using api = Surveys;

    /// <summary>
    /// Defines a response to a survey question
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public readonly struct QuestionResponse<T>
        where T : unmanaged
    {
        public uint QuestionId {get;}

        public QuestionChoice<T>[] Chosen {get;}

        public QuestionResponse(uint questionId, params QuestionChoice<T>[] chosen)
        {
            QuestionId = questionId;
            Chosen = chosen;
        }

        public string Format(bool bracket = false, char sep = Chars.Comma)
        {
            var sb = text.build();
            if(bracket)
                sb.Append(Chars.LBracket);

            for(var i=0; i<Chosen.Length; i++)
            {
                var chosen = Chosen[i];
                sb.Append($"({chosen.ChoiceId}) {chosen.Label}");
                if(i != Chosen.Length - 1)
                {
                    sb.Append(sep);
                    sb.Append(Chars.Space);
                }

            }

            if(bracket)
                sb.Append(Chars.RBracket);
            return sb.ToString();

        }

        public override string ToString()
            => Format();
    }
}