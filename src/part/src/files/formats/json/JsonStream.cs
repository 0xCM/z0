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
    using System.Text.Json;

    using static Root;
    using static core;

    using J = System.Text.Json.JsonTokenType;

    public ref struct JsonStream
    {
        public static JsonStream create(FS.FilePath src)
            => new JsonStream(src.Utf8Reader());

        readonly JsonReaderState State;

        readonly StreamReader Stream;

        readonly BinaryReader BinaryStream;

        readonly Span<byte> Buffer;

        bool ReadingArray;

        bool ReadingObject;


        [MethodImpl(Inline)]
        JsonStream(StreamReader stream)
        {
            Stream = stream;
            BinaryStream = Stream.BinaryReader(Encoding.UTF8);
            State = new JsonReaderState(new JsonReaderOptions{AllowTrailingCommas = true, CommentHandling = JsonCommentHandling.Skip});
            Buffer = alloc<byte>(Pow2.T14);
            ReadingArray=false;
            ReadingObject=false;
        }

        [MethodImpl(Inline)]
        Utf8JsonReader Reader(bool last)
            => new Utf8JsonReader(Buffer,last,State);

        public void Dispose()
        {
            Stream.Dispose();
        }

        public void Read()
        {
            var count = BinaryStream.Read(Buffer);
            while(count > 0)
            {
                var reader = Reader(count < Buffer.Length);
                while(reader.Read())
                {
                    switch(reader.TokenType)
                    {
                        case J.Comment:
                            TakeComment(reader);
                        break;
                        case J.StartArray:
                            BeginArrayRead(reader);
                        break;
                        case J.EndArray:
                            EndArrayRead(reader);
                        break;
                        case J.StartObject:
                            BeginObjectRead(reader);
                        break;
                        case J.EndObject:
                            EndObjectRead(reader);
                        break;
                        case J.Null:
                            TakeNull(reader);
                        break;
                        case J.Number:
                            TakeNumber(reader);
                        break;
                        case J.PropertyName:
                            TakePropName(reader);
                        break;
                        case J.String:
                            TakeString(reader);
                        break;
                        case J.True:
                        case J.False:
                            TakeBoolean(reader);
                        break;
                        default:
                            break;
                    }
                }

                Buffer.Clear();
                count = BinaryStream.Read(Buffer);
            }
        }

        void TakeNull(Utf8JsonReader reader)
        {

        }

        void TakeComment(Utf8JsonReader reader)
        {

        }

        void BeginArrayRead(Utf8JsonReader reader)
        {
            ReadingArray = true;

        }

        void EndArrayRead(Utf8JsonReader reader)
        {
            ReadingArray = false;
        }

        void BeginObjectRead(Utf8JsonReader reader)
        {
            ReadingObject = true;
        }

        void EndObjectRead(Utf8JsonReader reader)
        {
            ReadingObject = false;
        }

        void TakeNumber(Utf8JsonReader reader)
        {

        }

        void TakePropName(Utf8JsonReader reader)
        {

        }

        void TakeString(Utf8JsonReader reader)
        {

        }

        void TakeBoolean(Utf8JsonReader reader)
        {

        }
    }
}