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
    public readonly struct SurveyBuilder
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a stock survey that contains no meaningful content
        /// </summary>
        /// <param name="id">The survey id</param>
        /// <param name="name">The survey name</param>
        /// <param name="length">The number of questions in the survey</param>
        /// <param name="width">The (uniform) number of choices in each question</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static Survey<T> template<T>(uint id, string name, int length, int width)
            where T : unmanaged
        {
            var questions = new Question<T>[length];

            for(uint i=0u, questionId = 1; i<length; i++, questionId++)
            {
                var choices = new QuestionChoice<T>[width];
                var choiceId = one<T>();
                for(var j = 0u; j< width; j++)
                {
                    choices[j] = choice(choiceId, SurveyFormatter.label(j));
                    choiceId = gmath.sll(choiceId, (byte)1);
                }
                questions[i] = question(questionId, $"Question {questionId}", 1, choices);
            }
            return Survey(id,name,questions);
        }

        /// <summary>
        /// Creates a stock survey with the maximum number of questions/choices supported by the primal type
        /// </summary>
        /// <param name="id">The survey id</param>
        /// <param name="name">The survey name</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static Survey<T> template<T>(uint id, string name)
            where T : unmanaged
                => template<T>(id,name, bitsize<T>(), bitsize<T>());

        /// <summary>
        /// Creates a stock survey with a specified number of questions, each of which has the maximum number
        /// of choices supported by the primal type
        /// </summary>
        /// <param name="id">The survey id</param>
        /// <param name="name">The survey name</param>
        /// <param name="length">The number of questions in the survey</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static Survey<T> template<T>(uint id, string name, int length)
            where T : unmanaged
                => template<T>(id,name, length, bitsize<T>());

        /// <summary>
        /// Creates a choice for a survey question
        /// </summary>
        /// <param name="id">The question-relative choice identifier</param>
        /// <param name="label">The choice name</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static QuestionChoice<T> choice<T>(T id, string label)
            where T : unmanaged
                => new QuestionChoice<T>(id,label);

        /// <summary>
        /// Creates a question for a survey
        /// </summary>
        /// <param name="id">The survey-relative question identifier</param>
        /// <param name="statement">The question statement</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static Question<T> question<T>(uint id, string statement, int maxselect,  params QuestionChoice<T>[] choices)
            where T : unmanaged
                => new Question<T>(id, statement, maxselect, choices);

        /// <summary>
        /// Creates a response to a survey question
        /// </summary>
        /// <param name="questionId">The id of the question to which a response is given</param>
        /// <param name="chosen">The selected choices</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static QuestionResponse<T> response<T>(uint questionId, params QuestionChoice<T>[] chosen)
            where T : unmanaged
                => new QuestionResponse<T>(questionId, chosen);

        /// <summary>
        /// Creates a response to a survey
        /// </summary>
        /// <param name="surveyId">The id of the question to which a response is given</param>
        /// <param name="answered">The selected choices</param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static SurveyResponse<T> response<T>(uint surveyId, params QuestionResponse<T>[] answered)
            where T : unmanaged
                => new SurveyResponse<T>(surveyId, answered);

        /// <summary>
        /// Creates a survey
        /// </summary>
        /// <param name="id">The survey identifier, unique within some external scope</param>
        /// <param name="name">The name of the survey, unique within some external scope</param>
        /// <param name="questions"></param>
        /// <typeparam name="T">The primal data type used for survey aspect representation</typeparam>
        [Op, Closures(Closure)]
        public static Survey<T> Survey<T>(uint id, string name, params Question<T>[] questions)
            where T : unmanaged
                => new Survey<T>(id,name, questions);
    }
}