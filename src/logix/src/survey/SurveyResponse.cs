//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a response to a survey
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public readonly ref struct SurveyResponse<T>
        where T : unmanaged
    {
        /// <summary>
        /// The survey identifier
        /// </summary>
        public readonly uint SurveyId;

        /// <summary>
        /// The answered survey questions
        /// </summary>
        public readonly Span<QuestionResponse<T>> Answered;

        public SurveyResponse(uint id, params QuestionResponse<T>[] answered)
        {
            this.SurveyId = id;
            this.Answered = answered;
        }
        
        public override string ToString()
            => Survey.Format(this);
    }
}