//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using static zfunc;


    public class SurveyTest : UnitTest<SurveyTest>
    {

        public void survey_8u()
        {
            var survey = Survey.Template<byte>(1, "Survey 8u");
            var matrix = Survey.Matrix(survey);
            

        }

        public void survey_16u()
        {
            var survey = Survey.Template<ushort>(1, "Survey 16u", 11, 5);
            var matrix = Survey.Matrix(survey);
            var response = Survey.Respond(survey, Random);
            //Trace(response.Format());
            

        }

        public void survey_max32()
        {
            var survey = Survey.Template<uint>(1, "Survey 32u", 20);
            var matrix = Survey.Matrix(survey);
            
        }

        public void survey_max64()
        {
            var survey = Survey.Template<ulong>(1, "Survey 64u", 33, 17);
            var matrix = Survey.Matrix(survey);
            

        }

    }

}