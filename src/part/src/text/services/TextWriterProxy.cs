//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;


    public interface ITextWriter
    {
        IFormatProvider FormatProvider {get;}

        string NewLine {get;}

        void Close();

        void Flush();

        void Write(bool value);

        void Write(char value);

        void Write(char[]? buffer);

        void Write(char[] buffer, int index, int count);

        void Write(decimal value);

        void Write(double value);

        void Write(int value);

        void Write(long value);

        void Write(object? value);

        void Write(ReadOnlySpan<char> buffer);

        void Write(float value);

        void Write(string? value);

        void Write(string format, object? arg0);

        void Write(string format, object? arg0, object? arg1);

        void Write(string format, object? arg0, object? arg1, object? arg2);

        void Write(string format, params object?[] arg);

        void Write(StringBuilder? value);

        void Write(uint value);

        void Write(ulong value);

        Task WriteAsync(char value);

    }

    public sealed class TextWriterProxy : TextWriter, ITextWriter
    {
        readonly TextWriter Target;

        TextWriterProxy(TextWriter dst)
        {
            Target = dst;
        }

        public override Encoding Encoding
            => Target.Encoding;

        public override IFormatProvider FormatProvider
            => Target.FormatProvider;

        public override string NewLine
            => Target.NewLine;

        public override void Close()
        {
            Target.Close();
        }

        public override void Flush()
        {
            Target.Flush();
        }

        public override void Write(bool value)
        {
            Target.Write(value);
        }

        public override void Write(char value)
        {
            Target.Write(value);
        }


        public override void Write(char[]? buffer)
        {
            Target.Write(buffer);
        }


        public override void Write(char[] buffer, int index, int count)
        {
            Target.Write(buffer, index, count);
        }


        public override void Write(decimal value)
        {
            Target.Write(value);
        }

        public override void Write(double value)
        {
            Target.Write(value);
        }

        public override void Write(int value)
        {
            Target.Write(value);
        }

        public override void Write(long value)
        {
            Target.Write(value);
        }

        public override void Write(object? value)
        {
            Target.Write(value);
        }

        public override void Write(ReadOnlySpan<char> buffer)
        {
            Target.Write(buffer);
        }

        public override void Write(float value)
        {
            Target.Write(value);
        }

        public override void Write(string? value)
        {
            Target.Write(value);
        }

        public override void Write(string format, object? arg0)
        {
            Target.Write(format, arg0);
        }

        public override void Write(string format, object? arg0, object? arg1)
        {
            Target.Write(format, arg0, arg1);
        }

        public override void Write(string format, object? arg0, object? arg1, object? arg2)
        {
            Target.Write(format, arg0, arg1, arg2);
        }

        public override void Write(string format, params object?[] arg)
        {
            Target.Write(format, arg);
        }

        public override void Write(StringBuilder? value)
        {
            Target.Write(value);
        }

        public override void Write(uint value)
        {
            Target.Write(value);
        }

        public override void Write(ulong value)
         {
            Target.Write(value);
        }

        public override Task WriteAsync(char value)
        {
            return Target.WriteAsync(value);
        }
    }
}