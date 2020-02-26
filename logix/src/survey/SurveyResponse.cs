//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Defines a response to a survey
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public class SurveyResponse<T>
        where T : unmanaged
    {
        public SurveyResponse(uint id, params QuestionResponse<T>[] answered)
        {
            this.SurveyId = id;
            this.Answered = answered;
        }
        
        /// <summary>
        /// The survey identifier
        /// </summary>
        public uint SurveyId {get;}

        /// <summary>
        /// The answered survey questions
        /// </summary>
        public QuestionResponse<T>[] Answered {get;}

        public string Format()
        {
            var sb = text.factory.Builder();
            
            for(var i=0; i<Answered.Length; i++)
            {
                sb.Append(Answered[i].QuestionId);
                sb.Append(AsciSym.Colon);
                sb.Append(AsciSym.Space);
                sb.Append(Answered[i].Format());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public override string ToString()
            => Format();
    }
}