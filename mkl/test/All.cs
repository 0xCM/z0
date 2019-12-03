//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Diagnostics;    
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static nfunc;
    using static Examples;

    static class Examples
    {
        const string Intro = "beginning";
        const string Finale = "finished";

        static readonly string Divider = new string('-',80);
        
        public static (string method, string msg) intro(bool silent = true, [CallerMemberName] string method = null)
        {
            var line1 = $"{method} => {Intro}";
            var line2 = Divider;
            if(!silent)
            {
                cyan(line1);
                cyan(line2);
            }
            return  (method, line1 + eol() + line2);
        }

        public static (string method, string msg) varintro(string variation, bool silent = true, [CallerMemberName] string method = null)
        {
            var variant = $"{method}[{variation}]";
            var line1 = $"{variant} => {Intro}";
            var line2 = Divider;
            if(!silent)
            {
                print();
                cyan($"{variant} => {Intro}");
                cyan(Divider);
            }
            return (variant, line1 + eol() + line2);
        }


        public static string finale(string title, object value, Duration time, bool silent = true, [CallerMemberName] string method = null)
        {
            var line1 = $"Output {title}: {value}";
            var line2 = $"{method} => {Finale} | Runtime = {format(time)}";
            
            if(!silent)
            {
                magenta(line1);
                cyan(line2);
            }
            
            return line1 + eol() + line2;
        }

        [MethodImpl(Inline)]
        public static string finale(string title, object value, Stopwatch sw, bool silent = true, [CallerMemberName] string method = null)
            => finale(title, value, snapshot(sw), silent, method);

        public static string output(object output, bool silent = true)
        {
            var msg = $" Actual: {output}";
            if(!silent)
                magenta(msg);
            return msg;
        }

        public static string expected(object expect, bool silent = true)
        {
            var msg = $" Expect: {expect}";
            if(!silent)
                magenta(msg);
            return msg;
        }


        public static string conclude(Duration time, bool silent = true, [CallerMemberName] string method = null)    
        {
            var msg = $"Runtime: {format(time)}";
            if(!silent)            
            {
                cyan(msg);
                print();
            }
            return msg;
        }

        public static void input(object input)
            => cyan("  Input", input);

        public static string input(string title, object input, bool silent = true)
        {
            var msg = $"Input {title}: {input}";
            if(!silent)
            {
                cyan(msg);
            }
            return msg;
        }
            

        [MethodImpl(Inline)]
        public static (Stopwatch timer, string report) input(string firstTitle, object firstValue, string secondTitle, object secondValue, bool silent = true)
        {
            var report = text();
            report.AppendLine(input(firstTitle, firstValue, silent));
            report.AppendLine(input(secondTitle, secondValue, silent));
            return (stopwatch(), report.ToString());
        }

    
         public static string format(Duration time)
         {  
             return $"{time.Ms} ms";
         }

        public static string output(string title, object value, Duration time, bool silent = true)
        {
            var line1 = $"{title}: {value}";
            var line2 = $"Runtime: {format(time)}";
            if(!silent)
            {
                magenta(line1);
                magenta(line2);
            }
            return line1 + eol() + line2;

        }


        [MethodImpl(Inline)]
        public static double MaxEntry<M,N>(this NatSpan<M,N,double> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => src.Reduce(Math.Max);

        [MethodImpl(Inline)]
        public static int EntryPadWidth<M,N>(this NatSpan<M,N,double> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => ((long)src.Reduce(Math.Max)).ToDeciDigits().Length;


    }

    public static class CBLASX
    {

        [MethodImpl(Inline)]
        static Stopwatch start()
            => stopwatch();

        public static void sasum()
        {
            var silent = true;   
            (var method, var msg) = intro(silent);
            var n = 10;
            var incx = 1;
            Span<float> x = new float[]{1.0f,  -2.0f,  3.0f,  4.0f,  -5.0f,  6.0f,  -7.0f,  8.0f,  -9.0f,  10.0f};
            input(x.FormatAsVector());

            var sw = stopwatch();
            var result = CBLAS.cblas_sasum(n, ref x[0], incx);
            var time = snapshot(sw);            

            msg += output(result, silent);            
            msg += eol();
            msg += conclude(time, silent);            
        }

        public static void dzasum()
        {
            var silent = true;
            (var method, var msg) = intro(silent);            

            var n = 4;
            var incx = 1;
            var x =  ComplexF64.Load(new double[]{1.2, 2.5, 3.0, 1.7, 4.0, 0.53, -5.5, -0.29});
            msg += input(x.FormatAsVector(),silent);
            
            var expect = x.Map(z => Math.Abs(z.re) + Math.Abs(z.im)).Reduce((a,b) => a + b);
            expected(expect);


            var time = start();
            var result = CBLAS.cblas_dzasum(n, ref x[0], incx);            
            output("result", result, snapshot(time));

        }

        public static void saxpy()
        {
            (var method, var msg) = intro();
            var n = 5;
            var incx = 1;
            var incy = 1;
            var alpha = .5f;
            Span<float> x = new float[]{1, 2, 3, 4, 5};
            Span<float> y = new float[]{.5f, .5f, .5f, .5f, .5f};
            input($"alpha={alpha}, x = {x.FormatAsVector()}, y = {y.FormatAsVector()}");

            var sw = stopwatch();
            CBLAS.cblas_saxpy(n, alpha, ref x[0], incx, ref y[0], incy);
            var time = snapshot(sw);            

            output(y.FormatAsVector());
            conclude(time);                                    
        }

        static string gemm<M,N>(bool silent = true)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nati<M>();
            var n = nati<N>();
            (var method, var introMsg) = varintro($"{m}x{n} * {n}x{m} = {m}x{m}", silent);
            var count = m*n;
            
            var srcA = span<double>(count);
            for(var i=1; i<= count; i++)
                srcA[i-1] = i;
            var a = Matrix.blockload<M,N,double>(srcA);

            var srcB = span<double>(m*n);
            for(var i=1; i<= count; i++)
                srcB[i-1] = i;
            var b = Matrix.blockload<N,M,double>(srcB);

            (var timer, var startMsg) = input(
                nameof(a), a.Format(), 
                nameof(b), b.Format(),
                silent
                );            

            var c = mkl.gemm(a,b);            
            var time = snapshot(timer); 
            var finaleMsg = finale(nameof(c), c.Format(), timer, silent, method);
                
            var report = text();
            report.AppendLine(introMsg);
            report.AppendLine(startMsg);
            report.AppendLine(finaleMsg);
            return report.ToString();
        }
        
        public static void gemm()
        {
            var report = text();
            report.AppendLine(gemm<N3,N4>());
            report.AppendLine(gemm<N5,N7>());
            report.AppendLine(gemm<N10,N10>());
            report.AppendLine(gemm<N16,N16>());
            report.AppendLine(gemm<N17,N17>());
        }       
    }
}