//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a response to a survey question
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public class QuestionResponse<T>
        where T : unmanaged
    {
        public QuestionResponse(uint questionId, params QuestionChoice<T>[] chosen)
        {
            this.QuestionId = questionId;
            this.Chosen = chosen;
        }
        
        public uint QuestionId {get;}

        public QuestionChoice<T>[] Chosen {get;}

        public string Format(bool bracket = false, char sep = AsciSym.Comma)
        {
            var sb = text.factory.Builder();
            if(bracket)
                sb.Append(AsciSym.LBracket);

            for(var i=0; i<Chosen.Length; i++)
            {
                var chosen = Chosen[i];
                sb.Append($"({chosen.Id}) {chosen.Label}");
                if(i != Chosen.Length - 1)
                {
                    sb.Append(sep);
                    sb.Append(AsciSym.Space);
                }

            }

            if(bracket)
                sb.Append(AsciSym.RBracket);
            return sb.ToString();

        }

        public override string ToString()
            => Format();

    }
}