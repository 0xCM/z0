//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.IO;

    public class ReadVirtualStream : Stream
    {
        private long _pos;

        private readonly long _disp;

        private long _len;

        private readonly IDataReader _dataReader;

        public ReadVirtualStream(IDataReader dataReader, long displacement, long len)
        {
            _dataReader = dataReader;
            _disp = displacement;
            _len = len;
        }

        public override bool CanRead => true;
        
        public override bool CanSeek => true;
        
        public override bool CanWrite => false;

        public override void Flush()
        {
        }

        public override long Length 
            => throw new NotImplementedException();

        public override long Position
        {
            get => _pos;
            set
            {
                _pos = value;
                if (_pos > _len)
                    _pos = _len;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (_dataReader.Read((ulong)(_pos + _disp), new Span<byte>(buffer, offset, count), out int read))
            {
                if (read > 0)
                    _pos += read;

                return read;
            }

            return 0;
        }
        
        public override long Seek(long offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin:
                    _pos = offset;
                    break;

                case SeekOrigin.End:
                    _pos = _len + offset;
                    if (_pos > _len)
                        _pos = _len;
                    break;

                case SeekOrigin.Current:
                    _pos += offset;
                    if (_pos > _len)
                        _pos = _len;
                    break;
            }

            return _pos;
        }

        public override void SetLength(long value)
        {
            _len = value;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new InvalidOperationException();
        }
    }        
}