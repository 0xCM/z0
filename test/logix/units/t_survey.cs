//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;


    public class t_survey : UnitTest<t_survey>
    {
        void emit_asci_table()
        {
            using var dst = CaseWriter(FileExtensions.Csv);

            var min = (int)'A';
            var max = (int)'Z';

            for(var i = min; i<=max; i++)
            {
                dst.Write(Convert.ToChar(i).ToString().PadRight(4));
                dst.Write(Chars.Pipe);
                dst.Write(Chars.Space);
            }
            dst.WriteLine();

            for(var i = min; i<=max; i++)
            {
                dst.Write(i.ToString().PadRight(4));
                dst.Write(Chars.Pipe);
                dst.Write(Chars.Space);
            }
        }

        public void survey_8u()
        {
            var survey = SurveyBuilder.template<byte>(1, "Survey 8u");
            var matrix = Survey.Matrix(survey);

        }

        public void survey_16u()
        {
            var survey = SurveyBuilder.template<ushort>(1, "Survey 16u", 11, 5);
            var matrix = Survey.Matrix(survey);

            using var dst = BitMatrixServices.Factory.Writer(CasePath(FS.ext("survey.table")));
            dst.Write(matrix);

            var response = Survey.Respond(survey, Random);


        }

        public void survey_max32()
        {
            var survey = SurveyBuilder.template<uint>(1, "Survey 32u", 20);
            var matrix = Survey.Matrix(survey);
        }

        public void survey_max64()
        {
            var survey = SurveyBuilder.template<ulong>(1, "Survey 64u", 60, 10);
            var matrix = Survey.Matrix(survey);
            using var dst = BitMatrixServices.Factory.Writer(CasePath(FS.ext("table")));
            dst.Write(matrix);
        }
    }
}