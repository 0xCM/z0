//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;


    using static zfunc;

    public class t_survey : UnitTest<t_survey>
    {

        void emit_asci_table()
        {
            using var dst = LogArea.Test.LogWriter(FileName.Define("Asci.csv"));                
            
            var min = (int)'A';
            var max = (int)'Z';
            
            for(var i = min; i<=max; i++)
                dst.Write($"'{Convert.ToChar(i)}', ");
            dst.WriteLine();
            
            for(var i = min; i<=max; i++)
                dst.Write($"{i}, ");            
        }

        void survey_8u()
        {
            var survey = Survey.Template<byte>(1, "Survey 8u");
            var matrix = Survey.Matrix(survey);        
        }

        void survey_16u()
        {
            var survey = Survey.Template<ushort>(1, "Survey 16u", 11, 5);
            var matrix = Survey.Matrix(survey);
            var response = Survey.Respond(survey, Random);
        }

        void survey_max32()
        {
            var survey = Survey.Template<uint>(1, "Survey 32u", 20);
            var matrix = Survey.Matrix(survey);
            
        }

        void survey_max64()
        {
            var survey = Survey.Template<ulong>(1, "Survey 64u", 33, 17);
            var matrix = Survey.Matrix(survey);
        }
    }
}