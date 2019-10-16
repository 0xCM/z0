//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using static zfunc;


    public class SurveyTest : UnitTest<SurveyTest>
    {

        public void survey_max8()
        {
            var s1 = Survey.Template(1, "Survey 1", 20, (byte)8);
            Trace(s1.Format());

            var m = Survey.CreateMatrix(s1);
            Trace(m.Format());

        }

        void survey_max16()
        {
            var s1 = Survey.Template(1, "Survey 1", 20, (ushort)16);
            Trace(s1.Format());

        }

        void survey_max32()
        {
            var s1 = Survey.Template(1, "Survey 1", 20, (uint)32);
            Trace(s1.Format());

        }

        void survey_max64()
        {
            var s1 = Survey.Template(1, "Survey 1", 20, (ulong)64);
            Trace(s1.Format());

        }

    }

}