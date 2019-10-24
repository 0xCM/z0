//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using static zfunc;

    public static class Survey
    {
        static readonly char[] ChoiceLabels = new char[26]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        public static Survey<T> Template<T>(uint id, string label, uint questionCount, T questionLength)
            where T : unmanaged
        {
            var ql = convert<T,int>(questionLength);            

            var questions = new Question<T>[questionCount];
            for(uint i=0u, questionId = 1; i< questionCount; i++, questionId++)
            {
                var choices = new QuestionChoice<T>[ql];
                var choiceId = gmath.one<T>();
                for(var j = 0u; j< ql; j++)
                {                    
                    choices[j] = CreateChoice(choiceId, ChoiceLabel(j));
                    choiceId = gmath.sll(choiceId, 1);                    
                }
                questions[i] = CreateQuestion(questionId, $"Question {questionId}", 1, choices);
            }
            return CreateSuvey(id,label,questions);
        }
    
        [MethodImpl(Inline)]
        public static QuestionChoice<T> CreateChoice<T>(T id, string label)
            where T : unmanaged
                => new QuestionChoice<T>(id,label);

        [MethodImpl(Inline)]
        public static Question<T> CreateQuestion<T>(uint id, string label, int maxselect,  params QuestionChoice<T>[] choices)
            where T : unmanaged
                => new Question<T>(id, label, maxselect, choices);

        [MethodImpl(Inline)]
        public static Survey<T> CreateSuvey<T>(uint id, string label, params Question<T>[] questions)
            where T : unmanaged
                => new Survey<T>(id,label, questions);

        public static BitVector<T> CreateVector<T>(Question<T> src)
            where T : unmanaged
        {
            var data = default(T);
            foreach(var choice in src.Choices)
                gmath.or(ref data, choice.Id);
            return data;
        }

        public static RowBits<T> CreateMatrix<T>(Survey<T> src)
            where T : unmanaged
        {
            var rowcount = src.Questions.Count;
            var dst = RowBits.alloc<T>(rowcount);
            for(var i=0; i< rowcount; i++)
                dst[i] = CreateVector(src.Questions[i]);
            return dst;
        }

        static string ChoiceLabel(uint index)
        {
            if(index < 26)
                return ChoiceLabels[index].ToString();
            else 
                return new string(ChoiceLabels[index % 26].Replicate((index / 26) + 1));
        }

    }


}