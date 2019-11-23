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
        /// <summary>
        /// Creates a stock survey that contains no meaningful content
        /// </summary>
        /// <param name="id">The survey id</param>
        /// <param name="name">The survey name</param>
        /// <param name="length">The number of questions in the survey</param>
        /// <param name="width">The (uniform) number of choices in each question</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static Survey<T> Template<T>(uint id, string name, uint length, uint width)
            where T : unmanaged
        {

            var questions = new Question<T>[length];

            for(uint i=0u, questionId = 1; i< length; i++, questionId++)
            {
                var choices = new QuestionChoice<T>[width];
                var choiceId = gmath.one<T>();
                for(var j = 0u; j< width; j++)
                {                    
                    choices[j] = Choice(choiceId, ChoiceLabel(j));
                    choiceId = gmath.sll(choiceId, 1);                    
                }
                questions[i] = Question(questionId, $"Question {questionId}", 1, choices);
            }
            return CreateSuvey(id,name,questions);
        }

        /// <summary>
        /// Creates a stock survey with the maximum number of questions/choices supported by the primal type
        /// </summary>
        /// <param name="id">The survey id</param>
        /// <param name="name">The survey name</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [MethodImpl(Inline)]
        public static Survey<T> Template<T>(uint id, string name)
            where T : unmanaged
                => Template<T>(id,name, bitsize<T>(), bitsize<T>());

        /// <summary>
        /// Creates a stock survey with a specified number of questions, each of which has the maximum number 
        /// of choices supported by the primal type
        /// </summary>
        /// <param name="id">The survey id</param>
        /// <param name="name">The survey name</param>
        /// <param name="length">The number of questions in the survey</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [MethodImpl(Inline)]
        public static Survey<T> Template<T>(uint id, string name, uint length)
            where T : unmanaged
                => Template<T>(id,name, length, bitsize<T>());

        /// <summary>
        /// Creates a choice for a survey question
        /// </summary>
        /// <param name="id">The question-relative choice identifier</param>
        /// <param name="label">The choice name</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [MethodImpl(Inline)]
        public static QuestionChoice<T> Choice<T>(T id, string label)
            where T : unmanaged
                => new QuestionChoice<T>(id,label);

        /// <summary>
        /// Creates a question for a survey
        /// </summary>
        /// <param name="id">The survey-relative question identifier</param>
        /// <param name="statement">The question statement</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [MethodImpl(Inline)]
        public static Question<T> Question<T>(uint id, string statement, int maxselect,  params QuestionChoice<T>[] choices)
            where T : unmanaged
                => new Question<T>(id, statement, maxselect, choices);

        /// <summary>
        /// Creates a response to a survey question
        /// </summary>
        /// <param name="questionId">The id of the question to which a reponse is given</param>
        /// <param name="chosen">The selected choices</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [MethodImpl(Inline)]
        public static QuestionResponse<T> Response<T>(uint questionId, params QuestionChoice<T>[] chosen)
            where T : unmanaged
                => new QuestionResponse<T>(questionId, chosen);

        /// <summary>
        /// Creates a response to a survey
        /// </summary>
        /// <param name="surveyId">The id of the question to which a reponse is given</param>
        /// <param name="answered">The selected choices</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [MethodImpl(Inline)]
        public static SurveyResponse<T> Response<T>(uint surveyId, params QuestionResponse<T>[] answered)
            where T : unmanaged
                => new SurveyResponse<T>(surveyId, answered);

        /// <summary>
        /// Creates a survey
        /// </summary>
        /// <param name="id">The survey identifier, unique within some external scope</param>
        /// <param name="name">The name of the survey, unique within some external scope</param>
        /// <param name="questions"></param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [MethodImpl(Inline)]
        public static Survey<T> CreateSuvey<T>(uint id, string name, params Question<T>[] questions)
            where T : unmanaged
                => new Survey<T>(id,name, questions);

        public static QuestionResponse<T> Respond<T>(Question<T> question, IPolyrand random)
            where T : unmanaged
        {
            var count = question.Choices.Count;
            var index = random.Next(0,count);
            var chosen = question.Choices[index];
            return Response(question.Id, chosen);
        }

        public static SurveyResponse<T> Respond<T>(Survey<T> survey, IPolyrand random)
            where T : unmanaged
        {
            var answered = new QuestionResponse<T>[survey.Questions.Count];
            for(var i=0; i<answered.Length; i++)
                answered[i] = Respond(survey.Questions[i], random);
            return new SurveyResponse<T>(survey.Id, answered);
        }

        /// <summary>
        /// Creates a bitvector representation of a question
        /// </summary>
        /// <param name="src">The question upon which the bitvector will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitVector<T> Vector<T>(Question<T> src)
            where T : unmanaged
        {
            var data = default(T);
            foreach(var choice in src.Choices)
                data = gmath.or(data, choice.Id);
            return data;
        }

        /// <summary>
        /// Creates a bitvector representation of a question response
        /// </summary>
        /// <param name="src">The response upon which the bitvector will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitVector<T> Vector<T>(QuestionResponse<T> src)
            where T : unmanaged
        {
            var data = default(T);
            foreach(var choice in src.Chosen)
                data = gmath.or(data, choice.Id);
            return data;
        }

        /// <summary>
        /// Creates a bitmatrix representation of a survey response
        /// </summary>
        /// <param name="src">The survey upon which the matrix will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitMatrix<T> Matrix<T>(SurveyResponse<T> src)
            where T : unmanaged
        {
            var rowcount = src.Answered.Length;
            var maxrows = bitsize<T>();
            if(rowcount > maxrows)
                throw new Exception($"Too many rows for a primal bitmatrix");

            var dst = BitMatrix.alloc<T>();
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Answered[i]);
            return dst;                
        }

        /// <summary>
        /// Creates a bitmatrix representation of a survey
        /// </summary>
        /// <param name="src">The survey upon which the matrix will be predicated</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        public static BitMatrix<T> Matrix<T>(Survey<T> src)
            where T : unmanaged
        {
            var rowcount = src.Questions.Count;
            var maxrows = bitsize<T>();
            if(rowcount > maxrows)
                throw new Exception($"Too many rows for a primal bitmatrix");

            var dst = BitMatrix.alloc<T>();
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Questions[i]);
            return dst;                
        }

        public static RowBits<T> Rows<T>(Survey<T> src)
            where T : unmanaged
        {
            var rowcount = src.Questions.Count;
            var dst = RowBits.alloc<T>(rowcount);
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Questions[i]);
            return dst;
        }

        public static RowBits<T> Rows<T>(SurveyResponse<T> src)
            where T : unmanaged
        {
            var rowcount = src.Answered.Length;
            var dst = RowBits.alloc<T>(rowcount);
            for(var i=0; i< rowcount; i++)
                dst[i] = Vector(src.Answered[i]);
            return dst;

        }

        static string ChoiceLabel(uint index)
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